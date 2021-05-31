using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pub_Busters___Musical_Bingo
{
    public class SongData
    {
        private int _songID;
        private string _songName;
        private string _artistName;
        private int _yearCharted;
        private string _decadeOfSong;
        private string _youtubeLink;
        public SongData(int popID, string songName, string artistName, int yearCharted, string decadeOfSong, string youtubeLink)
        {
            _songID = popID;
            _songName = songName;
            _artistName = artistName;
            _yearCharted = yearCharted;
            _decadeOfSong = decadeOfSong;
            _youtubeLink = youtubeLink;
        }

        public int SongID
        {
            get { return _songID; }
        }

        public string SongName
        {
            get { return _songName; }
        }

        public string ArtistName
        {
            get { return _artistName; }
        }

        public int YearCharted
        {
            get { return _yearCharted; }
        }

        public string DecadeOfSong
        {
            get { return _decadeOfSong; }
        }

        public string YoutubeLink
        {
            get { return _youtubeLink; }
        }
    }
}
