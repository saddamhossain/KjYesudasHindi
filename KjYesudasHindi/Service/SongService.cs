using KjYesudasHindi.Interface;
using KjYesudasHindi.Model;
using KjYesudasHindi.SeedData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KjYesudasHindi.Service
{
    public class SongService : ISong
    {
        public IList<Song> GetSongs()
        {
            Seed seed = new Seed();
            var result = seed.songs.ToList();
            return result;
        }

        public IList<Song> GetSongByYear(int year)
        {
            Seed seed = new Seed();
            var result = seed.songs.Where(s => s.Year == year).ToList();
            return result;
        }

        public IList<Song> GetSongByMovieName(string movie)
        {
            Seed seed = new Seed();
            var result = seed.songs.Where(s => s.Movie.ToLower() == movie.ToLower()).ToList();
            return result;
        }

        public IList<Song> GetSongByMusicDirector(string musicDirector)
        {
            Seed seed = new Seed();
            var result = seed.songs.Where(s => s.Music.ToLower() == musicDirector.ToLower()).ToList();
            return result;
        }

        public IList<Song> GetSongByLyricist(string lyricist)
        {
            Seed seed = new Seed();
            var result = seed.songs.Where(s => s.Lyrics.ToLower() == lyricist.ToLower()).ToList();
            return result;
        }

        public IList<Song> GetSongByGenre(string genre)
        {
            Seed seed = new Seed();
            var result = seed.songs.Where(s => s.Genre.ToLower() == genre.ToLower()).ToList();
            return result;
        }


        #region IDisposable Support
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
