using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeographyGame
{
    public partial class Geography_Menu : Form
    {
        string selectedContinent;
        public Geography_Menu()
        {
            InitializeComponent();
        }

        private void GeographyMenu_Load(object sender, EventArgs e)
        {
         
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            selectedContinent = comboBoxContinent.Text;
            if (selectedContinent != null && selectedContinent != "")
            {
                Form newGame = new Geography_Game(selectedContinent);
                newGame.Show();
            }
            else
            {
                MessageBox.Show("Please select a continent");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
