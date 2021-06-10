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
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;
using MySqlDataAdapter = MySql.Data.MySqlClient.MySqlDataAdapter;
using MySqlDataReader = MySql.Data.MySqlClient.MySqlDataReader;
using System.Net;

namespace Science_Game_
{
    public partial class Inventions : Form
    {
        private InventionData currentInventor;
        int currentInventionIndex = 0;
        List<InventionData> _data;
        string path = Directory.GetCurrentDirectory() + "//";
        int lowerIndex = 0;
        int upperIndex = 3;
        int inventorsCorrect = 0;
        List<InventionData> _randomisedAnswers;
        List<int> _indexTaken;
        Random rnd = new Random();
        private int _randomNumber;
        private bool _newPosition;

        bool gameStart = false;

        List<InventionData> _inventionOrder;
        List<InventionData> _inventorOrder;

        public static Font TEXT_FONT = new Font("Roboto", 10);
        public static SolidBrush TEXT_BRUSH = new SolidBrush(Color.Purple);
        public Inventions(List<InventionData> data)
        {
            InitializeComponent();
            _data = data;
            DoubleBuffered = true;

        }

        private void pictureBoxInventorPic_MouseClick(object sender, MouseEventArgs e)
        {
            labelResult.Visible = true;
            bool correct = false;
            foreach (InventionData id in _inventorOrder)
            {
                if (id.isMouseOnInventor(e.X, e.Y))
                {
                    currentInventor = id;
                    if (currentInventor.InventorName == _inventionOrder[currentInventionIndex].InventorName)
                    {
                        correct = true;
                        labelResult.Text = "Correct";
                        inventorsCorrect++;
                        labelCorrect.Text = "Correct Count: " + inventorsCorrect.ToString();
                        if (inventorsCorrect == 3)
                        {
                            MessageBox.Show("You win! Good job!");
                            MessageBox.Show("You can continue playing or start a new game!");
                        }
                        break;
                    }
                }
            }
            if (correct)
            {
                _inventorOrder.Remove(currentInventor);
                currentInventor = null;
                drawInventor();
                currentInventionIndex++;
                drawInvention();
            }
            else
            {
                labelResult.Text = "Incorrect";
                
            }    
        }

        private void drawInventor()
        {
            //Reset values to be unclickable until they are drawn
            foreach (InventionData inventor in _inventorOrder)
            {
                inventor.X = 0;
                inventor.Y = -121;
            }

            int xPos = 0;
            int yPos = 0;
            pictureBoxInventorPic.Refresh();
            Graphics paper = pictureBoxInventorPic.CreateGraphics();
            for (int i = lowerIndex; i < upperIndex + 1; i++)
            {
                string filename = path + "Inventor" + _inventorOrder[i].DataID + ".png";
                Image img = new Bitmap(filename);
                paper.DrawImage(img, xPos, yPos, 80, 120);

                paper.DrawString(_inventorOrder[i].InventorName, TEXT_FONT, TEXT_BRUSH, xPos, yPos + 120);

                _inventorOrder[i].X = xPos;
                _inventorOrder[i].Y = yPos;
                yPos = yPos + 145;
            }
        }
        private void drawInvention()
        {
            pictureBoxInventionPic.Refresh();
            Graphics paper = pictureBoxInventionPic.CreateGraphics();
            string filename = path + "Invention" + _inventionOrder[currentInventionIndex].DataID + ".png";
            Image img = new Bitmap(filename);
            paper.DrawImage(img, 0, 0, img.Width / 4, img.Height / 4);

            labelInventionName.Text = "Invention: " + _inventionOrder[currentInventionIndex].InventionName;
        }

        private void buttonScrollUp_Click(object sender, EventArgs e)
        {
            if (gameStart == true)
            {
                if (lowerIndex - 1 >= 0)
                {
                    lowerIndex -= 1;
                    upperIndex -= 1;
                    drawInventor();
                }
                else
                {
                    lowerIndex = 0;
                    upperIndex = 3;
                }
            }
        }

        private void buttonScrollDown_Click(object sender, EventArgs e)
        {
            if (gameStart == true)
            {
                if (upperIndex + 1 < _inventorOrder.Count)
                {
                    lowerIndex += 1;
                    upperIndex += 1;
                    drawInventor();
                }
                else
                {
                    lowerIndex = _inventorOrder.Count - 4;
                    upperIndex = _inventorOrder.Count - 1;
                }
            }
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            inventorsCorrect = 0;
            _inventorOrder = ShuffleAnswers();
            drawInventor();
            _inventionOrder = ShuffleAnswers();
            currentInventionIndex = 0;
            drawInvention();

            //Reset values to be unclickable until they are drawn
            foreach (InventionData inventor in _inventorOrder)
            {
                inventor.X = 0;
                inventor.Y = -121;
            }

            gameStart = true;
        }

        public List<InventionData> ShuffleAnswers()
        {
            _randomisedAnswers = new List<InventionData>();
            _indexTaken = new List<int>();
            foreach (InventionData p in _data)
            {
                _newPosition = false;
                //Get a unique random number not taken before
                while (_newPosition == false)
                {
                    _randomNumber = rnd.Next(0, _data.Count);
                    //Check the object at the index in the initial list is not the new list
                    if (!_indexTaken.Contains(_randomNumber))
                    {
                        _indexTaken.Add(_randomNumber);
                        _newPosition = true;
                        //Add the object at the index in the initial list to the new list
                        _randomisedAnswers.Add(_data[_randomNumber]);
                    }
                }
            }
            return _randomisedAnswers;
        }

        private void Inventions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_data != null && _data.Count > 0)
            {
                AskPicDelete d = new AskPicDelete(_data);
                d.ShowDialog();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}