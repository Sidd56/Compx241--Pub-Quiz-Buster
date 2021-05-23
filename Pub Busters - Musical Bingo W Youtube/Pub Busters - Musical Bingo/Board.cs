using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pub_Busters___Musical_Bingo
{
    class Board
    {
        public SquareOnBoard[,] squares;
        //The minimum size of the board
        public int NUM_SQUARES_ON_SIDE = 3;

        //Instantiate a new 2D "rectangle" array to detect whether user has clicked on them
        Rectangle[,] _squaresToClick;
        //The width of a block on board
        protected int _squareWidthSize;
        //The length of a block on board
        protected int _squareHeightSize;

        public Board()
        {
            _squaresToClick = new Rectangle[NUM_SQUARES_ON_SIDE, NUM_SQUARES_ON_SIDE];
            squares = new SquareOnBoard[NUM_SQUARES_ON_SIDE, NUM_SQUARES_ON_SIDE];
        }

        /// <summary>
        /// The width of a square on board
        /// </summary>
        public int SquareWidthSize
        {
            get { return _squareWidthSize; }
            set { _squareWidthSize = value; }
        }

        /// <summary>
        /// The height of a square on board
        /// </summary>
        public int SquareHeightSize
        {
            get { return _squareHeightSize; }
            set { _squareHeightSize = value; }
        }

        public void DrawBoard(Graphics paper, bool firstDraw)
        {
            //x and y positions to draw grid squares
            int x = 0;
            int y = 0;

            //For each row to draw
            for (int i = 0; i < NUM_SQUARES_ON_SIDE; i++)
            {
                //For each column to draw
                for (int j = 0; j < NUM_SQUARES_ON_SIDE; j++)
                {
                    //Assigns rectangles for the user to click on to each square
                    _squaresToClick[i, j] = new Rectangle(x, y, SquareWidthSize, SquareHeightSize);
                    if (firstDraw == true)
                    {
                        squares[i, j] = new SquareOnBoard(SquareWidthSize, SquareHeightSize, i, j);
                    }
                    else
                    {
                        squares[i, j].SquareWidth = SquareWidthSize;
                        squares[i, j].SquareHeight = SquareHeightSize;
                    }
                    //Draws the square
                    squares[i, j].Draw(paper, Color.LightYellow);
                    //Shifts the current position of x one square right
                    x += SquareWidthSize;
                }
                //Shifts the current position of y one square downwards for drawing the next row
                y += SquareHeightSize;
                //Resets the position of x to be at the start of the new row
                x = 0;
            }
        }

        public void HighlightAgain(Graphics paper)
        {
            for (int i = 0; i < NUM_SQUARES_ON_SIDE; i++)
            {
                //For each column to draw
                for (int j = 0; j < NUM_SQUARES_ON_SIDE; j++)
                {
                    if (squares[i, j].Highlighted == true)
                    {
                        squares[i, j].Highlight(paper);
                    }
                }
            }
        }

        public (int i, int j) GetArrayPosition(int x, int y)
        {
            for (int i = 0; i < NUM_SQUARES_ON_SIDE; i++)
            {
                for (int j = 0; j < NUM_SQUARES_ON_SIDE; j++)
                {
                    //Determines whether the mouse clicked position is within a particular rectangle
                    if (_squaresToClick[i, j].Contains(x, y))
                    {
                        return (i, j);
                    }
                }
            }
            //Clicked out of squares
            return (-1, -1);
        }
    }
}
