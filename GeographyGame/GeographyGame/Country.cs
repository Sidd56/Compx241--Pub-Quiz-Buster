using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GeographyGame
{
    class Country
    {
        int _currentXSize, _currentYSize;
        public int _x, _y, _currentsize, _trueX, _trueY;
        Pen pen = new Pen(Color.Black);
        Brush brush = new SolidBrush(Color.Red);
        int _numRand;
        bool _selected = false;
        bool _delete = false;
        bool _isCorrect = false;
        public int _statType;
        string _name;
        //The correct statistic e.g. population, land area
        ulong _trueStat;
        //The list of options, which includes trueStat and other options
        double[] _statOptions = new double[5];
        int _sizeX;
        int _sizeY;

        string _continent;
        int _correctOption;
        int currentOption;
        int num = 0;
        string directory = Directory.GetCurrentDirectory() + @"..\..\..\..\";
        string filename;
        public bool withFlag;
        /// <summary>
        /// Create a country
        /// </summary>
        /// <param name="name">The name of the country</param>
        /// <param name="x">The starting x location</param>
        /// <param name="y">The starting y location</param>
        /// <param name="trueX">The correct x location on the map</param>
        /// <param name="trueY">The correct y location on the map</param>
        /// <param name="stat">The number value of the statistic e.g. GDP</param>
        public Country(string name, int x, int y, int trueX, int trueY, string continent, ulong stat, int sizeX, int sizeY, int statType, int randNum)
        {
            _name = name;
            _x = x;
            _y = y;
            _trueX = trueX;
            _trueY = trueY;
            _trueStat = stat;
            Move(x, y);
            _sizeX = sizeX;
            _sizeY = sizeY;
            _continent = continent;
            _statType = statType;
            _numRand = randNum;
            GenerateOptions();
            //deleted stattype since we dont need it. we can just have count the database thing
        }
        public string Stattype()
        {
            if (_statType == 4)
            {
                return "Population";
            }
            else
            {
                return "Area";
            }
        }
        public bool WithFlag
        {
            get { return withFlag; }
            set { withFlag = value; }
        }
        private int CorrectOption
        {
            get { return _correctOption; }

        }
        public int CurrentOption
        {
            get { return currentOption; }
            set { currentOption = value; }
        }
        public string Name
        {
            get { return _name; }
        }
        public ulong stats
        {
            get { return _trueStat; }
            set { _trueStat = value; }
        }

        public double[] StatOptions
        {
            get { return _statOptions; }
            set { _statOptions = value; }
        }
        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }
        public bool IsCorrect
        {
            get { return _isCorrect; }
            set { _isCorrect = value; }
        }
        public string Continent
        {
            get { return _continent; }
        }
        public int SizeX
        {
            get
            {
                return _sizeX;
            }
            set
            {
                _sizeX = value;
            }
        }
        public int SizeY
        {
            get { return _sizeY; }
            set { _sizeY = value; }
        }

        public bool Delete
        {
            get { return _delete; }
            set { _delete = value; }
        }
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public int CurrentSize
        {
            get { return _currentsize; }
            set { _currentsize = value; }
        }
        public void GenerateOptions()
        {
            double gen;

            _statOptions[_numRand] = 1;
            _correctOption = _numRand;
            for (int i = 0; i <= 4; i++)
            {

                if (i < _numRand)
                {
                    gen = (double)(1.0 - (0.15 * (double)(_numRand - i)));
                    _statOptions[i] = gen;
                }
                else if (i > _numRand)
                {
                    gen = (1 + (0.15 * (i - _numRand)));
                    _statOptions[i] = gen;
                }
            }
            currentOption = 2;

            //gen = (ulong)((double)_trueStat * (double)(1.0 - (0.1 * (double)(rand - i))));
            //_statOptions[i] = gen;
        }
        public bool isCorrect()
        {

            if (currentOption == CorrectOption)
            {
                if (X >= _trueX - 4 && X <= _trueX + 4)
                {
                    if (Y >= _trueY - 4 && Y <= _trueY + 4)
                    {
                        return true;
                    }
                }
            }


            return false;

        }
        public void countryPaint(DirectoryInfo d, FileInfo item, Graphics paper)
        {

            // if (country != null && country._name + ".png" == item.Name) 
            if (this.WithFlag == true)
            {

                filename = d.ToString() + this._name + "_WithFlag.png";
                Image img = new Bitmap(filename);
                //  paper.DrawImage(img, _x, _y, (int)((img.Width * StatOptions[currentOption])), (int)((img.Height * StatOptions[currentOption])));
                paper.DrawImage(img, _trueX, _trueY, img.Width, img.Height);
                this._sizeX = img.Width;
                this._sizeY = img.Height;
            }
            else if (this.IsCorrect == true)
            {
                filename = d.ToString() + this._name + "_Correct.png";
                Image img = new Bitmap(filename);
                paper.DrawImage(img, _trueX, _trueY, img.Width, img.Height);
                this._sizeX = img.Width;
                this._sizeY = img.Height;
                Font TEXT_FONT = new Font("Roboto", 10);
                if (Stattype() == "Area")
                {
                    paper.DrawString(Name + " has " + Stattype() + " of " + stats + "km^2", TEXT_FONT, Brushes.Purple, _trueX, Y+_currentYSize/2);
                }
                else if (Stattype() == "Population")
                {
                    paper.DrawString(Name + " has " + Stattype() + " of " + stats + " PEOPLE", TEXT_FONT, Brushes.Purple, _trueX, Y+_currentYSize/2);
                }
            }
            else if (this.Selected == true)
            {

                filename = d.ToString() + this._name + "_Selected.png";
                Image img = new Bitmap(filename);
                paper.DrawImage(img, _x, _y, (int)((img.Width * StatOptions[currentOption])), (int)((img.Height * StatOptions[currentOption])));
                _currentXSize = (int)(img.Width * StatOptions[currentOption]);
                _currentYSize = (int)(img.Height * StatOptions[currentOption]);
                this._sizeX = img.Width;
                this._sizeY = img.Height;
            }

            else
            {

                if (this._name + ".png" == item.Name)
                {
                    filename = d.ToString() + item.ToString();
                    Image img = Image.FromFile(filename);
                    paper.DrawImage(img, _x, _y, (int)((img.Width * StatOptions[currentOption])), (int)((img.Height * StatOptions[currentOption])));
                    this._sizeX = img.Width;
                    this._sizeY = img.Height;
                }
            }
        }
        public void Draw(Graphics paper, string continent)
        {
            _continent = continent;
            if (continent == "South America")
            {
                DirectoryInfo d = new DirectoryInfo(directory + @"SA\");
                FileInfo[] Files = d.GetFiles("*");
                foreach (var item in Files)
                {
                    countryPaint(d, item, paper);
                }

            }
            if (continent == "Europe")
            {
                DirectoryInfo d = new DirectoryInfo(directory + @"Europe\");
                FileInfo[] Files = d.GetFiles("*");
                foreach (var item in Files)
                {
                    countryPaint(d, item, paper);
                }
            }
        }
        public void Move(int x, int y)
        {
            X = x - _currentXSize / 2;
            Y = y - _currentYSize / 2;
        }
        public bool IsMouseOn(int x, int y)
        {
            if (X <= x && x <= X + this.SizeX
                && Y <= y && y <= Y + this.SizeY)
                return true;
            else
                return false;
        }

    }

}

