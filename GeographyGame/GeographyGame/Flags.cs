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
    class Flags
    {
        string directory = Directory.GetCurrentDirectory() + @"..\..\..\..\";
        string filename;
        int _y;
        int _x;
        string _country;
        public List<string> countries = new List<string>();
        public Flags(string country, int y)
        {
            _country = country;
            _y = y;
        }
        public int Y
        {
            get { return _y; }
            set { value = _y; }
        }
        public int X
        {
            get { return _x; }
            set { value = _x;  }
        }
        public string fName
        {
            get { return _country;  }
        }
        public void DrawFlag(Graphics paper, string continent)
        {

            DirectoryInfo directoryInfo = new DirectoryInfo(directory + @"Flags\");
            FileInfo[] files = directoryInfo.GetFiles("*");
            int i = 0;
            foreach (var item in files)
            {
                if (_country + continent + ".png" == item.Name)
                {
                    filename = directoryInfo.ToString() + _country + continent + ".png";
                    Image img = new Bitmap(filename);
                    paper.DrawImage(img, 0, Y, (img.Width) / 3, (img.Height) / 3);
                    i++;
                }
            }
        }
        public bool isMouseOn(int y)
        {
            if (Y <= y && y <= Y + 177)
                return true;
            else
                return false;
        }
    }
}
