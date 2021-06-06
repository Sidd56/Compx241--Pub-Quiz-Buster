using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using MySql.Data.MySqlClient;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;
using MySqlDataAdapter = MySql.Data.MySqlClient.MySqlDataAdapter;
using MySqlDataReader = MySql.Data.MySqlClient.MySqlDataReader;

using MediaToolkit;
using MediaToolkit.Model;
using VideoLibrary;

namespace Pub_Busters___Musical_Bingo
{
    public partial class Music_Menu : Form
    {
        List<SongData> popData;
        public Music_Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Downloads a mp4 file from a youtube video
        /// </summary>
        /// <param name="SaveToFolder">Directory to save in</param>
        /// <param name="VideoURL">Youtube link</param>
        /// <param name="MP4Name">The custom name given to the mp4</param>
        private void SaveMP4(string SaveToFolder, string VideoURL, string MP4Name)
        {
            string source = SaveToFolder;
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(VideoURL);
            string videopath = Path.Combine(source, $"{MP4Name}.mp4");
            File.WriteAllBytes(videopath, vid.GetBytes());

            var inputFile = new MediaFile { Filename = Path.Combine(source, $"{MP4Name}.mp4") };
        }

        /// <summary>
        /// Connecting the MySQL database with this program and creating a new list of results
        /// </summary>
        /// <param name="mySql">The query</param>
        private void ConnectWithDatabase(string mySql)
        {
            popData = new List<SongData>();
            string connectionstring = @"datasource=sql6.freesqldatabase.com;port=3306;database=sql6412717;username=sql6412717;password=9B8lPlBL4v";
            MySqlDataReader reader = null;
            MySqlConnection conn = new MySqlConnection(connectionstring);
            MySqlCommand command = new MySqlCommand(mySql, conn);
            conn.Open();
            MySql.Data.MySqlClient.MySqlDataAdapter dtb = new MySqlDataAdapter(mySql, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                SongData s = new SongData(int.Parse(reader.GetString(0)), reader.GetString(1), reader.GetString(2),
                    int.Parse(reader.GetString(3)), reader.GetString(4), reader.GetString(5));
                popData.Add(s);

            }
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonYearRange.Checked == true || radioButtonDecade.Checked == true)
                {
                    bool songFound = false;
                    string mySql = "";
                    if (radioButtonYearRange.Checked == true)
                    {
                        int yearStart = 0;
                        int yearEnd = 0;
                        yearStart = int.Parse(textBoxStartYear.Text);
                        yearEnd = int.Parse(textBoxEndYear.Text);
                        if (yearEnd >= yearStart)
                        {
                            mySql = "SELECT * FROM Songs where Year_Charted between '" + yearStart + "' and '" + yearEnd + "' " +
                                "order by RAND() LIMIT 9";
                        }
                    }
                    if (radioButtonDecade.Checked == true)
                    {
                        if (string.IsNullOrEmpty(comboBoxDecades.Text))
                        {
                            mySql = "SELECT * FROM Songs order by RAND() LIMIT 9";
                        }
                        else
                        {
                            mySql = "SELECT * FROM Songs where Decade_Of_Song like '" + comboBoxDecades.Text + 
                                "' order by RAND() LIMIT 9";
                        }
                    }
                   
                    if (mySql != "")
                    {
                        ConnectWithDatabase(mySql);
                        if (popData.Count > 0)
                        {
                            progressBarLoading.Value = 0;
                            //Same directory of the executable file
                            string videoPath = Directory.GetCurrentDirectory() + "\\";
                            //Check if the song already exists in the directory
                            foreach (SongData s in popData)
                            {
                                songFound = false;
                                labelDownload.Visible = true;
                                foreach (string mFile in Directory.GetFiles(Directory.GetCurrentDirectory() + "\\","Song" + s.SongID + ".mp4"))
                                {
                                     songFound = true;
                                     break;
                                }

                                //Song not found, so download the mp4 of the song
                                if (songFound == false)
                                {
                                    SaveMP4(videoPath, s.YoutubeLink, "Song" + s.SongID);
                                }
                                progressBarLoading.Value += 100 / popData.Count;
                            }

                            labelDownload.Visible = false;
                            progressBarLoading.Value = progressBarLoading.Maximum;

                            Musical_Bingo b = new Musical_Bingo(popData, videoPath);
                            b.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("There are currently no songs in the selected year period");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Check if data has been inputted correctly e.g. end year is greater than start year");
                    }
                }
                else
                {
                    MessageBox.Show("Please select to either be quizzed by year range or decade");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonYearRange_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYearRange.Checked == true)
            {
                labelStartYear.Visible = true;
                textBoxStartYear.Visible = true;
                labelEndYear.Visible = true;
                textBoxEndYear.Visible = true;
            }
            else
            {
                labelStartYear.Visible = false;
                textBoxStartYear.Visible = false;
                labelEndYear.Visible = false;
                textBoxEndYear.Visible = false;
            }
        }

        private void radioButtonDecade_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDecade.Checked == true)
            {
                comboBoxDecades.Visible = true;
                comboBoxDecades.SelectedIndex = 0;
            }
            else
            {
                comboBoxDecades.Visible = false;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
