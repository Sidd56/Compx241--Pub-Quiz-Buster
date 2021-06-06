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
    public partial class GeographyGame : Form
    {

        List<Country> countries;
        List<Country> correctCountries = new List<Country>();

        Random rand = new Random();
        string _continent;
        Country current = null;
        Country prevCur = null;
        Flags flag;
        List<Flags> flags;
        Flags currentFlag = null;
        int yflag = 0;
        public GeographyGame(string continent)
        {

            InitializeComponent();

            int randNum;
            try
            {
                countries = new List<Country>();
                flags = new List<Flags>();
                _continent = continent;
                string connectionstring = @"datasource=sql6.freesqldatabase.com;port=3306;database=sql6412717;username=sql6412717;password=9B8lPlBL4v";
                string mySQL = "SELECT * from Countries where Continent = '" + continent + "'";
                MySQLDataReader reader = null;
                MySQLConnection conn = new MySQLConnection(connectionstring);
                conn.Open();
                MySqlCommand command = new MySqlCommand(mySQL, conn);
                MySql.Data.MySqlClient.MySqlDataAdapter dtb = new MySQLDataAdapter(mySQL, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int X = rand.Next(500, pictureBoxDisplay.Width);
                    int Y = rand.Next(0, pictureBoxDisplay.Height);
                    int StatType = rand.Next(5, 7);
                    if (reader.GetString(3) != "" && reader.GetString(2) != "")
                    {
                        randNum = rand.Next(0, 5);
                        Country c = new Country(reader.GetString(1), X, Y, int.Parse(reader.GetString(2)), int.Parse(reader.GetString(3)), reader.GetString(4), ulong.Parse(reader.GetString(StatType)), 0, 0, StatType, randNum); flag = new Flags(c.Name, yflag);
                        flags.Add(flag);
                        yflag = yflag + 177;
                        countries.Add(c);
                    }
                    Console.WriteLine(reader.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.WindowState = FormWindowState.Maximized;
            if (continent == "South America")
            {
                string directory = Directory.GetCurrentDirectory() + @"..\..\..\..\SA\SouthAmericaBackground.png";
                pictureBoxDisplay.BackgroundImage = new Bitmap(directory);
                pictureBoxDisplay.Height = pictureBoxDisplay.BackgroundImage.Height;
                pictureBoxDisplay.Width = pictureBoxDisplay.BackgroundImage.Width + 200;
            }
            pictureBoxFlag.Left = pictureBoxDisplay.Left + pictureBoxDisplay.Width + 100;
            pictureBoxFlag.Top = pictureBoxDisplay.Height / 3;
            lblFlag.Left = pictureBoxFlag.Left;
            lblFlag.Top = pictureBoxFlag.Top + pictureBoxFlag.Height + 20;
        }

        private void trackBarCountryStat_Scroll(object sender, EventArgs e)
        {
            if (prevCur != null)
            {
                prevCur.CurrentOption = trackBarCountryStat.Value;
                updateLabel();
            }
        }

        private void UpdateTrackBar()
        {
            if (prevCur != null)
            {
                trackBarCountryStat.Value = prevCur.CurrentOption;
                updateLabel();
            }
        }
        private void updateLabel()
        {
            if (prevCur != null)
            {
                statLabel.Text = ((ulong)((double)prevCur.stats * prevCur.StatOptions[prevCur.CurrentOption])).ToString();
                labelCountryName.Text = prevCur.Name;
                lblStatType.Text = prevCur.Stattype();
            }
            else
            {
                statLabel.Text = "";
                labelCountryName.Text = "";
                lblStatType.Text = "";
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            bool notForm = true;
            foreach (Country item in countries)
            {


                if (item.IsMouseOn(e.X, e.Y))
                {
                    if (prevCur != item && prevCur != null)
                    {
                        prevCur.Selected = false;
                    }
                    current = item;
                    prevCur = current;
                    current.Selected = true;
                    item.X = e.X;
                    item.Y = e.Y;
                    item.Draw(pictureBoxDisplay.CreateGraphics(), item.Continent);
                    notForm = false;
                    updateLabel();
                    UpdateTrackBar();
                }
                if (notForm)
                {
                    if (prevCur != null)
                    {
                        prevCur.Selected = false;
                    }
                }

                pictureBoxDisplay.Invalidate();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {


            if (current != null)
            {
                current.Draw(pictureBoxDisplay.CreateGraphics(), current.Name);
                current.Move(e.X, e.Y);
                Console.WriteLine("X: " + (current.X - current._trueX).ToString() + ", Y: " + (current.Y - current._trueY).ToString());
                if (current.isCorrect())
                {
                    current.IsCorrect = true;
                    correctCountries.Add(current);
                    countries.Remove(current);
                    current = null;
                    prevCur = null;

                }
            }
            pictureBoxDisplay.Invalidate();
            labelX.Text = "X:" + e.X.ToString();
            labelY.Text = "Y:" + e.Y.ToString();

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            prevCur = current;
            current = null;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in countries)
            {
                item.Draw(e.Graphics, _continent);

            }

            // if (correctCountries.Count != 0)
            {
                foreach (var item in correctCountries)
                {
                    item.Draw(e.Graphics, _continent);

                }
            }

            this.Invalidate();
        }

        private void pictureBoxDisplay_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBoxFlag_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in flags)
            {
                item.DrawFlag(e.Graphics, _continent);
            }

        }

        private void pictureBoxFlag_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxFlag_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Flags flags in flags)
            {
                flags.isMouseOn(e.Y);
                if (flags.isMouseOn(e.Y))
                {
                    Console.WriteLine(flags.fName);
                }
            }
        }
    }
}
