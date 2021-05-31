using Pub_Busters___Musical_Bingo;
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
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
            pictureBoxLogo.Image = Properties.Resources.Pub_Quiz_Buster_Logo;
            //SoundPlayer simpleSound = new SoundPlayer("C:\\Users\\Jeffrey Luo\\Documents\\2021\\2021 Programs\\Pub Quiz\\Nintendo-Wii-Mii-Channel-Theme.wav");
            //simpleSound.Play();
        }

        private void buttonPlayMusicalBingo_Click(object sender, EventArgs e)
        {
            Music_Menu b = new Music_Menu();
            this.Hide();
            b.Show();
        }
    }
}
