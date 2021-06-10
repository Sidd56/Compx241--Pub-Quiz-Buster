using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pub_Busters___Musical_Bingo
{
    public class SongData
    {
        public readonly int SongID;
        public readonly string SongName;
        public readonly string ArtistName;
        public readonly int YearCharted;
        public readonly string DecadeOfSong;
        public readonly string YoutubeLink;
        public SongData(int popID, string songName, string artistName, 
            int yearCharted, string decadeOfSong, string youtubeLink)
        {
            SongID = popID;
            SongName = songName;
            ArtistName = artistName;
            YearCharted = yearCharted;
            DecadeOfSong = decadeOfSong;
            YoutubeLink = youtubeLink;
        }
    }
}