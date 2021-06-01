using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace GeographyGame
{
    class Country
    {

        int _x, _y, _currentsize, _trueX, _trueY;
        Pen pen = new Pen(Color.Black);
        Brush brush = new SolidBrush(Color.Red);
        Random random;
        bool Selected = false;
        bool _delete = false;
        string _name;
        //The correct statistic e.g. population, land area
        ulong _trueStat;
        //The list of options, which includes trueStat and other options
        ulong[] _statOptions = new ulong[5];
        int _sizeX;
        int _sizeY;
        string _continent;
        /// <summary>
        /// Create a country
        /// </summary>
        /// <param name="name">The name of the country</param>
        /// <param name="x">The starting x location</param>
        /// <param name="y">The starting y location</param>
        /// <param name="trueX">The correct x location on the map</param>
        /// <param name="trueY">The correct y location on the map</param>
        /// <param name="stat">The number value of the statistic e.g. GDP</param>
        public Country(string name, int x, int y,  int trueX, int trueY, string continent, ulong stat, int sizeX, int sizeY)
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
            //deleted stattype since we dont need it. we can just have count the database thing
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

        private void GenerateOptions()
        {
            int rand;
            ulong gen;
            rand = random.Next(0, 5);
            _statOptions[rand] = _trueStat;
            

            for (int i = 0; i <= 4; i++)
            {
                if (i < rand)
                {
                    gen = _trueStat * (ulong)(1 - (0.1 * (rand - i)));
                    _statOptions[i] = gen;
                }
                else if (i > rand)
                {
                    gen = _trueStat * (ulong)(1 + (0.1 * (i - rand)));
                    _statOptions[i] = gen;
                }
            }
        }
        public void Draw(Graphics paper,string continent, Country country)
        {
            string directory = Directory.GetCurrentDirectory() + @"..\..\..\..\";
            string filename;
            //The image of the country will be displayed to paper
            if (continent == "South America")
            { 
                DirectoryInfo d = new DirectoryInfo(directory + @"SA\");
                FileInfo[] Files = d.GetFiles("*");


                foreach (var item in Files)
                {
                    if (item.Name.Equals("SouthAmericaBackground.png"))
                    {
                        filename = d.ToString() + "SouthAmericaBackground.png";                   
                        Image img = new Bitmap(filename);
                        paper.DrawImage(img, 0, 0, img.Width, img.Height);
                        this._sizeX = img.Width;
                        this._sizeY = img.Height;
                    }
                    if (country != null && country._name + ".png" == item.Name)
                    {
                            filename = d.ToString() + country._name + "_Selected.png";
                            Image img = new Bitmap(filename);
                            paper.DrawImage(img,_x, _y, img.Width, img.Height);
                            this._sizeX = img.Width;
                            this._sizeY = img.Height;
                    }
                    else
                    {
                        if (this._name + ".png" == item.Name)
                        {
                            filename = d.ToString() + item.ToString();
                            Image img = Image.FromFile(filename);
                            paper.DrawImage(img, _x, _y, img.Width, img.Height);
                            this._sizeX = img.Width;
                            this._sizeY = img.Height;
                        }
                    }
                }
            }
            if (continent == "Europe")
            {
                DirectoryInfo d = new DirectoryInfo(directory + @"Europe\");
                FileInfo[] Files = d.GetFiles("*");
                foreach (var item in Files)
                {
                    if ((this._name + ".png").Equals(item.Name))
                    {
                        filename = d.ToString() + item.ToString();
                        Image img = Image.FromFile(filename);
                        paper.DrawImage(img, _x, _y, img.Width, img.Height);
                        this.SizeX = img.Width;
                        this.SizeY = img.Height;                       
                    }
                }
            }
        }
        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
        public bool IsMouseOn(int x, int y, Country country)
        {
            if (X <= x && x < X + country.SizeX
                && Y <= y && y < Y + country.SizeY)
                return true;
            else
                return false;
        }

    }

}

