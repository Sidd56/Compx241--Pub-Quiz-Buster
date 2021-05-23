using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pub_Busters___Musical_Bingo
{
    class BingoAnswers
    {
        public List<SongData> _initialData;
        public List<SongData> _randomisedAnswers;
        public List<int> _indexTaken;

        Random rnd = new Random();
        private int _randomNumber;
        private bool _newPosition;
        public BingoAnswers(List<SongData> initialData)
        {
            _initialData = initialData;
        }

        public List<SongData> ShuffleAnswers()
        {
            _randomisedAnswers = new List<SongData>();
            _indexTaken = new List<int>();
            foreach (SongData p in _initialData)
            {
                _newPosition = false;
                while (_newPosition == false)
                {
                    _randomNumber = rnd.Next(0, _initialData.Count);

                    if (!_indexTaken.Contains(_randomNumber))
                    {
                        _indexTaken.Add(_randomNumber);
                        _newPosition = true;

                        _randomisedAnswers.Add(_initialData[_randomNumber]);
                    }
                }
            }
            return _randomisedAnswers;
        }

        public void AssignAnswers(Board b, List<SongData> randomAnswers, bool quizSongName, bool quizArtistName)
        {
            int index = 0;
            for (int i = 0; i < b.NUM_SQUARES_ON_SIDE; i++)
            {
                for (int j = 0; j < b.NUM_SQUARES_ON_SIDE; j++)
                {
                    if (index > randomAnswers.Count-1)
                    {
                        return;
                    }

                    b.squares[i, j].Data = _randomisedAnswers[index];

                    if (quizSongName == true)
                    {
                        b.squares[i, j].Text = b.squares[i, j].Data.SongName.ToString();
                    }
                    else
                    {
                        b.squares[i, j].Text = b.squares[i, j].Data.ArtistName.ToString();
                    }
                    index++;
                }
            }
        }
    }
}
