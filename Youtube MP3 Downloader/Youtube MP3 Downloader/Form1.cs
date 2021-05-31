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

namespace Youtube_MP3_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxLoading.Text = "Idle";
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            string videoURL = textBoxYoutubeUrl.Text;
            SaveMP3("C:\\Users\\Jeffrey Luo\\Documents\\2021\\2021 Programs\\Pub Quiz", videoURL,"JB");
        }

        private void SaveMP3(string SaveToFolder, string VideoURL, string MP3Name)
        {
            textBoxLoading.Text = "Loading...";
            string source = SaveToFolder;
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(VideoURL);
            string videopath = Path.Combine(source, vid.FullName);
            File.WriteAllBytes(videopath, vid.GetBytes());

            var inputFile = new MediaFile { Filename = Path.Combine(source, vid.FullName) };
            var outputFile = new MediaFile { Filename = Path.Combine(source, $"{MP3Name}.mp3") };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
                engine.Convert(inputFile, outputFile);
            }

            File.Delete(Path.Combine(source, vid.FullName));
            textBoxLoading.Text = "Idle";
            MessageBox.Show("Downloaded");
        }

        private void DeleteFiles()
        {
            foreach (string mFile in Directory.GetFiles("C:\\Users\\Jeffrey Luo\\Documents\\2021\\2021 Programs\\Pub Quiz", "*.mp3"))
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
