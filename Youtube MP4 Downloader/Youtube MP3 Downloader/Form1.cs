using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaToolkit;
using MediaToolkit.Model;
using VideoLibrary;
using System.IO;
using MySql.Data.MySqlClient;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;
using MySqlDataAdapter = MySql.Data.MySqlClient.MySqlDataAdapter;
using MySqlDataReader = MySql.Data.MySqlClient.MySqlDataReader;


namespace Youtube_MP3_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxLoading.Text = "Idle";
        }
        string videoURL = "";
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            //string videoURL = textBoxYoutubeUrl.Text;
            //SQL Connection
            try
            {
                string connectionstring = @"datasource=sql6.freesqldatabase.com;port=3306;database=sql6412717;username=sql6412717;password=9B8lPlBL4v";
                string mySql = "SELECT * FROM Songs";
                MySqlDataReader reader = null;
                MySqlConnection conn = new MySqlConnection(connectionstring);
                MySqlCommand command = new MySqlCommand(mySql, conn);
                conn.Open();
                MySql.Data.MySqlClient.MySqlDataAdapter dtb = new MySqlDataAdapter(mySql, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (videoURL != "")
                    {
                        break;
                    }
                    videoURL = reader.GetString(5);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (videoURL != "")
            {
                SaveMP4("C:\\Users\\Jeffrey Luo\\Documents\\2021\\2021 Programs\\Pub Quiz", videoURL, "Song1");
                musicPlayer.URL = "C:\\Users\\Jeffrey Luo\\Documents\\2021\\2021 Programs\\Pub Quiz\\Song1.mp4";
            }
        }

        private void SaveMP4(string SaveToFolder, string VideoURL, string MP4Name)
        {
            textBoxLoading.Text = "Loading...";
            string source = SaveToFolder;
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(VideoURL);
            string videopath = Path.Combine(source, $"{MP4Name}.mp4");
            File.WriteAllBytes(videopath, vid.GetBytes());

            var inputFile = new MediaFile { Filename = Path.Combine(source, $"{MP4Name}.mp4") };
            //var outputFile = new MediaFile { Filename = Path.Combine(source, $"{MP3Name}.mp3") };

            //using (var engine = new Engine())
            //{
            //    engine.GetMetadata(inputFile);
            //    engine.Convert(inputFile, outputFile);
            //}

            //File.Delete(Path.Combine(source, vid.FullName));
            textBoxLoading.Text = "Idle";
            MessageBox.Show("Downloaded");
        }

        private void DeleteFiles()
        {
            foreach (string mFile in Directory.GetFiles("C:\\Users\\Jeffrey Luo\\Documents\\2021\\2021 Programs\\Pub Quiz", "*.mp4"))
            {
                File.Delete(mFile);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DeleteFiles();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeleteFiles();
        }
    }
}
