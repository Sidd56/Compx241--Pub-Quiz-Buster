using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pub_Busters___Musical_Bingo
{
    class SquareOnBoard
    {
        public static Font TEXT_FONT = new Font("Roboto", 20);
        public static SolidBrush TEXT_BRUSH = new SolidBrush(Color.Black);
        //Pen for drawing grid
        Pen dottedLinePen = new Pen(Color.LightGray, 2);

        private int _currentAnswerID;
        private int _squareWidth;
        private int _squareHeight;
        private int _rowPos;
        private int _colPos;
        private Color _defaultColour;
        private string _text;
        private bool _highlighted;
        private bool _correct;
        private SongData _data;
        public SquareOnBoard(int squareWidth, int squareHeight, int rowPos, int colPos)
        {
            _squareWidth = squareWidth;
            _squareHeight = squareHeight;
            _rowPos = rowPos;
            _colPos = colPos;
            _highlighted = false;
            _correct = false;
        }

        public int CurrentAnswerID
        {
            get { return _currentAnswerID; }
            set { _currentAnswerID = value; }
        }

        public int SquareWidth
        {
            get { return _squareWidth; }
            set { _squareWidth = value; }
        }

        public int SquareHeight
        {
            get { return _squareHeight; }
            set { _squareHeight = value; }
        }

        public int RowPos
        {
            get { return _rowPos; }
        }

        public int ColPos
        {
            get { return _colPos; }
        }

        public Color DefaultColour
        {
            get { return _defaultColour; }
            set { _defaultColour = value; }
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public bool Correct
        {
            get { return _correct; }
            set { _correct = value; }
        }

        public bool Highlighted
        {
            get { return _highlighted; }
            set { _highlighted = value; }
        }

        public SongData Data
        {
            get { return _data; }
            set { _data = value; }
        }

        /// <summary>
        /// Highlights the square letting player know whether answer is correct or not
        /// </summary>
        /// <param name="correct">Whether clicked bingo answer is correct or not</param>
        /// <param name="canvas">The graphics object where the square is drawn</param>
        public void Highlight(Graphics canvas)
        {
            if (Correct)
            {
                Draw(canvas, Color.LightGreen);
                Highlighted = true;
            }
            else
            {
                Draw(canvas, Color.Red);
                Highlighted = true;
            }
        }

        /// <summary>
        /// Draws a square for the board
        /// </summary>
        /// <param name="canvas">The graphics object where the square is drawn</param>
        /// <param name="SquareColor">The colour of the square</param>
        public void Draw(Graphics paper, Color newSquareColor)
        {
            dottedLinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            Rectangle square = new Rectangle(ColPos * SquareWidth, RowPos * SquareHeight, SquareWidth, SquareHeight);
            SolidBrush br1 = new SolidBrush(newSquareColor);
            paper.FillRectangle(br1, square);
            //Draws the grid square
            paper.DrawRectangle(dottedLinePen, square);
            paper.DrawString(Text, TEXT_FONT, TEXT_BRUSH, square);
        }
    }
}
