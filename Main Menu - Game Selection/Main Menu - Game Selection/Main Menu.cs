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

namespace Main_Menu___Game_Selection
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
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

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
