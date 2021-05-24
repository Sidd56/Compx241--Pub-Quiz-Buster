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
            //SQL Connection
            //try
            //{
            //    string connectionstring = @"datasource=sql6.freesqldatabase.com;port=3306;database=sql6412717;username=sql6412717;password=9B8lPlBL4v";
            //    string mySql = "SELECT * FROM Songs";
            //    MySqlDataReader reader = null;
            //    MySqlConnection conn = new MySqlConnection(connectionstring);
            //    MySqlCommand command = new MySqlCommand(mySql, conn);
            //    conn.Open();
            //    MySql.Data.MySqlClient.MySqlDataAdapter dtb = new MySqlDataAdapter(mySql, conn);
            //    reader = command.ExecuteReader();
            //    //while (reader.Read())
            //    //{
            //    //    Console.WriteLine(reader.GetString(5));
            //    //}
            //    while (reader.Read())
            //    {
            //        SongData s = new SongData(int.Parse(reader.GetString(0)), reader.GetString(1), reader.GetString(2),
            //            int.Parse(reader.GetString(3)), reader.GetString(4), reader.GetString(5));
            //            popData.Add(s);
                    
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void SaveMP4(string SaveToFolder, string VideoURL, string MP4Name)
        {
            string source = SaveToFolder;
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(VideoURL);
            string videopath = Path.Combine(source, $"{MP4Name}.mp4");
            File.WriteAllBytes(videopath, vid.GetBytes());

            var inputFile = new MediaFile { Filename = Path.Combine(source, $"{MP4Name}.mp4") };
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            try
            {
                popData = new List<SongData>();
                string connectionstring = @"datasource=sql6.freesqldatabase.com;port=3306;database=sql6412717;username=sql6412717;password=9B8lPlBL4v";
                string mySql;
                if (string.IsNullOrEmpty(comboBoxDecades.Text))
                {
                    mySql = "SELECT * FROM Songs order by RAND() LIMIT 9";
                }
                else
                {
                    mySql = "SELECT * FROM Songs where Decade_Of_Song like '" + comboBoxDecades.Text + "' order by RAND() LIMIT 9";

                }
                MySqlDataReader reader = null;
                MySqlConnection conn = new MySqlConnection(connectionstring);
                MySqlCommand command = new MySqlCommand(mySql, conn);
                conn.Open();
                MySql.Data.MySqlClient.MySqlDataAdapter dtb = new MySqlDataAdapter(mySql, conn);
                reader = command.ExecuteReader();
                //while (reader.Read())
                //{
                //    Console.WriteLine(reader.GetString(5));
                //}
                while (reader.Read())
                {
                    SongData s = new SongData(int.Parse(reader.GetString(0)), reader.GetString(1), reader.GetString(2),
                        int.Parse(reader.GetString(3)), reader.GetString(4), reader.GetString(5));
                        popData.Add(s);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DeleteFiles();
            progressBarLoading.Value = 0;
            foreach (SongData s in popData)
            {
                labelDownload.Visible = true;
                //SaveMP4("C:\\Users\\Jeffrey Luo\\Documents\\2021\\2021 Programs\\Pub Quiz\\", s.YoutubeLink, "Song" + s.SongID);
                SaveMP4(@"", s.YoutubeLink, "Song" + s.SongID);
                progressBarLoading.Value += 100 / popData.Count;
            }
            labelDownload.Visible = false;
            progressBarLoading.Value = progressBarLoading.Maximum;

            Musical_Bingo b = new Musical_Bingo(popData);
            b.Show();
        }

        private void DeleteFiles()
        {
            foreach (string mFile in Directory.GetFiles(@"", "*.mp4"))
            {
                File.Delete(mFile);
            }
        }

        private void Music_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeleteFiles();
        }
    }
}
