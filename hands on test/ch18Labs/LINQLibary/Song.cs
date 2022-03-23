using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLibary
{
    public class Song
    {
        public string SongTitle { get; set; }
        public string SongArtist { get; set;}
        public string SongGenre { get; set; }
        public override string ToString()
        {
            return "Song title:  " + SongTitle + "\n" + "Song Artist:" + SongArtist + "\n" + "Song Genre:" + SongGenre;
        }
    }
}
