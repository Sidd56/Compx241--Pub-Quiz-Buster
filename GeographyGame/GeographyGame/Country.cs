using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeographyGame
{
    class Country
    {

        int _x, _y, _currentsize, _trueX, _trueY;
        Pen pen = new Pen(Color.Black);
        Brush brush = new SolidBrush(Color.Red);
        const int Size = 50;
        Random random;
        bool _delete = false;
        string _name;
        string _statType;//Used to tell whether the stat is population or land area etc

        //The correct statistic e.g. population, land area
        ulong _trueStat;
        //The list of options, which includes trueStat and other options
        ulong[] _statOptions = new ulong[5];

        /// <summary>
        /// Create a country
        /// </summary>
        /// <param name="name">The name of the country</param>
        /// <param name="x">The starting x location</param>
        /// <param name="y">The starting y location</param>
        /// <param name="trueX">The correct x location on the map</param>
        /// <param name="trueY">The correct y location on the map</param>
        /// <param name="stat">The number value of the statistic e.g. GDP</param>
        public Country(string name, int x, int y, int trueX, int trueY, ulong stat, string statType)
        {
            _name = name;
            _x = x;
            _y = y;
            _trueX = trueX;
            _trueY = trueY;
            _trueStat = stat;
            _statType = statType;
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


        public void Draw(Graphics paper)
        {
            //The image of the country will be displayed to paper
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

}

