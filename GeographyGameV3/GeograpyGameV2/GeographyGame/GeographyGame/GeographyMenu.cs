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
    public partial class GeographyMenu : Form
    {
        string selectedContinent;
        public GeographyMenu()
        {
            InitializeComponent();
        }

        private void GeographyMenu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Github here");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            selectedContinent = comboBoxContinent.Text;
            if (selectedContinent != null && selectedContinent != "")
            {
                Form newGame = new GeographyGame(selectedContinent);
                newGame.Show();
            }
            else
            {
                MessageBox.Show("Please select a continent");//git this bish
            }
        }

       
    }
}
