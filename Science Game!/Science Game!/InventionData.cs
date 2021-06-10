using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Science_Game_
{
    public class InventionData
    {
        private int _dataId;
        private string _inventionName;
        private string _inventorName;
        private int _x;
        private int _y;
        private int _width;
        private int _height;
        private string _imgInventor;
        private string _imgInvention;
        private int sizeX = 80;
        private int sizeY = 120;

        public InventionData(int id, string inventorName, string inventionName, string imgInvention, string imgInventor, int X, int Y)
        {
            _dataId = id;
            _inventionName = inventionName;
            _inventorName = inventorName;
            _x = X;
            _y = Y;
            _imgInvention = imgInvention;
            _imgInventor = imgInventor;
        }

        public int DataID
        {
            get { return _dataId; }
        }

        public string InventionName
        {
            get { return _inventionName; }
        }

        public string InventorName
        {
            get { return _inventorName; }
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
        public int width
        {
            get { return _width; }
            set { _width = value; }
        }
        public bool isMouseOnInventor(int x, int y)
        {
            if ((x < X + sizeX && x > X) && (y < Y + sizeY && y > Y))
            {
                return true;
            }
            return false;
        }       
    }
}
