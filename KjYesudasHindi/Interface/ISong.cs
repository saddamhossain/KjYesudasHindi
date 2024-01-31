using KjYesudasHindi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KjYesudasHindi.Interface
{
    public interface ISong : IDisposable
    {
        IList<Song> GetSongs();
        IList<Song> GetSongByYear(int year);
        IList<Song> GetSongByMovieName(string movie);
        IList<Song> GetSongByMusicDirector(string musicDirector);
        IList<Song> GetSongByLyricist(string lyricist);
        IList<Song> GetSongByGenre(string genre);
    }
}
