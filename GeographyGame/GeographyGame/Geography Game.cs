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
using System.Drawing;
using MySql.Data.MySqlClient;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySQLConnection = MySql.Data.MySqlClient.MySqlConnection;
using MySQLDataAdapter = MySql.Data.MySqlClient.MySqlDataAdapter;
using MySQLDataReader = MySql.Data.MySqlClient.MySqlDataReader;
namespace GeographyGame
{
    public partial class Geography_Game : Form
    {

        List<Country> countries;
       
        Random rand = new Random();
        string _continent; 
        Country current = null;
        public Geography_Game(string continent)
        {

            InitializeComponent();
            try
            {
                countries = new List<Country>();
                _continent = continent;
                string connectionstring = @"datasource=sql6.freesqldatabase.com;port=3306;database=sql6412717;username=sql6412717;password=9B8lPlBL4v"; string mySQL = "SELECT * from Countries where Continent = '" + continent + "'";
                MySQLDataReader reader = null;
                MySQLConnection conn = new MySQLConnection(connectionstring);    
                conn.Open();
                MySqlCommand command = new MySqlCommand(mySQL, conn); 
               MySql.Data.MySqlClient.MySqlDataAdapter dtb = new  MySQLDataAdapter(mySQL, conn);
                 reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int X = rand.Next(500,pictureBoxDisplay.Width);
                    int Y = rand.Next(0,pictureBoxDisplay.Height);
                    int StatType = rand.Next(5, 7);
                    if (reader.GetString(2) != "" && reader.GetString(2) != "")
                    {
                        Country c = new Country(reader.GetString(1), X, Y, int.Parse(reader.GetString(2)), int.Parse(reader.GetString(3)), reader.GetString(4), ulong.Parse(reader.GetString(StatType)), 0, 0);
                        countries.Add(c);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Source);
            }

        }

        private void trackBarCountryStat_Scroll(object sender, EventArgs e)
        {

        }

        private void UpdateTrackBar()
        { 
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Country item in countries)
            {
                if (item.IsMouseOn(e.X, e.Y, item))
                {
                    pictureBoxDisplay.Invalidate();
                    current = item;
                    item.X = e.X;
                    item.Y = e.Y;
                    item.Draw(pictureBoxDisplay.CreateGraphics(), item.Continent, item);
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (current != null)
            {
                pictureBoxDisplay.Invalidate();
                current.X = e.X;
                current.Y = e.Y;
                current.Draw(pictureBoxDisplay.CreateGraphics(), current.Continent, current);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            current = null;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in countries)
            {
                if (item.Equals(current))
                {
                    current.Draw(e.Graphics, _continent, null);
                }
                else
                {
                    item.Draw(e.Graphics, _continent, null);
                }
            }
        }
    }
}
