using GeographyGame;
using Pub_Busters___Musical_Bingo;
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
using Science_Game_;

namespace Main_Menu___Game_Selection
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
            PlayTitleMusic();
        }

        private void PlayTitleMusic()
        {
            string videoPath = Directory.GetCurrentDirectory() + "\\";
            bool songFound = false;
            foreach (string mFile in Directory.GetFiles(Directory.GetCurrentDirectory() + "\\", "Title Music.mp3"))
            {
                songFound = true;
                break;
            }
            if (songFound == true)
            {
                titleMusicPlayer.URL = videoPath + "Title Music.mp3";
            }
        }

        private void pictureBoxTitle_Click(object sender, EventArgs e)
        {
            titleMusicPlayer.URL = "";
            pictureBoxTitle.Hide();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            pictureBoxTitle.Show();
            PlayTitleMusic();
        }

        private void buttonGeography_Click(object sender, EventArgs e)
        {
            GeographyMenu g = new GeographyMenu();
            g.ShowDialog();
        }

        private void buttonPlayMusicalBingo_Click(object sender, EventArgs e)
        {
            Music_Menu m = new Music_Menu();
            m.ShowDialog();
        }

        private void buttonScience_Click(object sender, EventArgs e)
        {
            Science_Game s = new Science_Game();
            s.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
