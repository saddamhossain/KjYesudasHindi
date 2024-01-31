using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KjYesudasHindi.Model
{
    public class Song
    {
        public string SongName { set; get; }
        public string Movie { set; get; }
        public int Year { set; get; }
        public string Music { set; get; }
        public string Lyrics { set; get; }
        public List<string> CoSinger { set; get; }
        public string Genre { set; get; }
        public string YoutubeLink { set; get; }
        public bool IsEmbedAllowed { set; get; }
    }
}
