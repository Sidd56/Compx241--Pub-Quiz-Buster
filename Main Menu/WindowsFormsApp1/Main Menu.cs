using Pub_Busters___Musical_Bingo;
using GeographyGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
            pictureBoxLogo.Image = Properties.Resources.Pub_Quiz_Buster_Logo;
        }

        private void buttonGeography_Click(object sender, EventArgs e)
        {
            Geography_Menu g = new Geography_Menu();
            g.ShowDialog();
        }

        private void buttonPlayMusicalBingo_Click(object sender, EventArgs e)
        {
            Music_Menu b = new Music_Menu();
            b.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
