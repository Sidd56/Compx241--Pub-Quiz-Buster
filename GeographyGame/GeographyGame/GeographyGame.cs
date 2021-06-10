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
using MySql.Data.MySqlClient;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySQLConnection = MySql.Data.MySqlClient.MySqlConnection;
using MySQLDataAdapter = MySql.Data.MySqlClient.MySqlDataAdapter;
using MySQLDataReader = MySql.Data.MySqlClient.MySqlDataReader;
using System.Text.Json;
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
        bool finished = false;
        List<Flags> flagCorrect = new List<Flags>();
        public GeographyGame(string continent)
        {

            InitializeComponent();           
            int randNum;
            try
            {
                countries = new List<Country>();
                flags = new List<Flags>();
                _continent = continent;
                labelMap.Text = "MAP OF " + _continent.ToUpper();
                string connectionstring = @"datasource=sql6.freesqldatabase.com;port=3306;database=sql6417439;username=sql6417439;password=xlUKVETect";
                string mySQL = "SELECT * from Countries2 where Continent = '" + continent + "'";
                MySQLDataReader reader = null;
                MySQLConnection conn = new MySQLConnection(connectionstring);
                conn.Open();
                MySqlCommand command = new MySqlCommand(mySQL, conn);
                MySql.Data.MySqlClient.MySqlDataAdapter dtb = new MySQLDataAdapter(mySQL, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int X = 0;
                    int Y = rand.Next(0, pictureBoxDisplay.Height);
                    int StatType = rand.Next(4, 6);
                    if (reader.GetString(2) != "" && reader.GetString(3) != "")
                    {
                        randNum = rand.Next(0, 5);
                        Country c = new Country(reader.GetString(0), X, Y, int.Parse(reader.GetString(2)), int.Parse(reader.GetString(3)), reader.GetString(1), ulong.Parse(reader.GetString(StatType)), 0, 0, StatType, randNum); flag = new Flags(c.Name, yflag);
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
            if (continent == "Europe")
            {
                string directory = Directory.GetCurrentDirectory() + @"..\..\..\..\Europe\EuropeBackground.png";
                pictureBoxDisplay.BackgroundImage = new Bitmap(directory);
                pictureBoxDisplay.Height = pictureBoxDisplay.BackgroundImage.Height;
                pictureBoxDisplay.Width = pictureBoxDisplay.BackgroundImage.Width + 200;
      
            }
            foreach (Country c in countries)
            {
                c.X = pictureBoxDisplay.Width - 200;
            }
            pictureBoxFlag.Left = pictureBoxDisplay.Width + pictureBoxDisplay.Left;
            //labelPieces.Top = pictureBoxFlag.Top + pictureBoxFlag.Height;
        }
      
        private void buttonGetData_Click_1(object sender, EventArgs e)
        {
            
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
                    if (countries.Count == 0)
                    {
                        finished = true;
                        MessageBox.Show("Round 2: Flags!");
                        //labelAssignFlags.Visible = true;
                        pictureBoxFlag.Visible = true;
                    }
                }
            }
            pictureBoxDisplay.Invalidate();
            labelX.Text = "X:" + e.X.ToString();
            labelY.Text = "Y:" + e.Y.ToString();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (countries.Count == 0)
            {
                Drawflags();
            }
            if (flags.Count == 0)
            {
                MessageBox.Show("Congratulations! You win!");
                DialogResult dresult = MessageBox.Show("Exit App", "Do you want to restart?", MessageBoxButtons.YesNo);
                if (dresult == DialogResult.Yes)
                {
                    MessageBox.Show("You will be prompted back to the start to choose another country");
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }
            }
            prevCur = current;
            current = null;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in countries)
            {
                item.Draw(e.Graphics, _continent);
            }
            foreach (var item in correctCountries)
            {
                item.Draw(e.Graphics, _continent);

            }
            this.Invalidate();
        }

        private void pictureBoxDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentFlag != null)
            {
                foreach (var item in correctCountries)
                {
                    if (item.IsMouseOn(e.X, e.Y))
                    {
                        if (currentFlag.fName == item.Name)
                        {
                            flagCorrect.Add(currentFlag);
                            flags.Remove(currentFlag);
                            currentFlag = null;
                            item.WithFlag = true;
                            item.Draw(this.CreateGraphics(), _continent);
                            Drawflags();
                            return;
                        }
                    }
                }
            }
        }

        private void pictureBoxFlag_Paint(object sender, PaintEventArgs e)
        {
            if (countries.Count == 0)
            {
                foreach (var item in flags)
                {
                    item.DrawFlag(e.Graphics, _continent);
                }
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
                    currentFlag = flags;
                    Console.WriteLine(flags.fName);
                }
            }
            pictureBoxFlag.Invalidate();
        }
        public void Drawflags()
        {
            foreach (Flags flags in flags)
            {
                flags.DrawFlag(pictureBoxFlag.CreateGraphics(), _continent);
            }
            pictureBoxFlag.Invalidate();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
