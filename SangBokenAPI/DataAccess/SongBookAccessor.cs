using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SangBokenAPI.Models;

namespace SangBokenAPI.DataAccess
{
    public class SongBookAccessor : AccessorBase
    {
        public IEnumerable<SongBookInfo> GetAllSongBooks()
        {
            return Context.SongBooks.Select(d => new SongBookInfo { Id = d.Key, Name = d.Name }).ToList();
        }

        // GET: api/SongBook/5
        public SongBookInfo GetSongBook(int id)
        {
            var song = Context.SongBooks.Include("Songs").SingleOrDefault(d => d.Key == id);
            return new SongBookInfo { Id = song.Key, Name = song.Name, Songs = song.Songs.Select(d => d.SongKey).ToArray() };
        }

        // POST: api/SongBook
        public void AddSongBook(SongBookInfo value)
        {
            using (var context = Context)
            {
                var songBook = new SongBook {Name = value.Name};
                songBook.Songs = value.Songs.Select(d => new SongInSongBook {SongBook = songBook, SongKey = d}).ToList();
                context.SongBooks.Add(songBook);
                context.SaveChanges();
            }
        }

        // PUT: api/SongBook/5
        public void UpdateSongBook(int id, SongBookInfo value)
        {
            using (var context = Context)
            {
                var existing = context.SongBooks.SingleOrDefault(d => d.Key == id);
                if (existing != null)
                {
                    context.SongsInSongBooks.RemoveRange(
                        context.SongsInSongBooks.Where(d => d.SongBookKey == existing.Key));
                }
                existing?.Update(value);
                context.SaveChanges();
            }
        }

        // DELETE: api/SongBook/5
        public void DeleteSongBook(int id)
        {
            using (var context = Context)
            {
                var existing = context.SongBooks.SingleOrDefault(d => d.Key == id);
                if (existing == null) return;
                context.SongBooks.Remove(existing);
                context.SaveChanges();
            }
        }
    }
}