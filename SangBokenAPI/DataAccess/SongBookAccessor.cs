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
        public SongBook GetSongBook(int id)
        {
            return Context.SongBooks.Include("Songs").SingleOrDefault(d => d.Key == id);
        }

        // POST: api/SongBook
        public void AddSongBook(SongBook value)
        {
            using (var context = Context)
            {
                value.Key = 0;
                context.SongBooks.Add(value);
                context.SaveChanges();
            }
        }

        // PUT: api/SongBook/5
        public void UpdateSongBook(int id, SongBook value)
        {
            using (var context = Context)
            {
                var existing = context.SongBooks.SingleOrDefault(d => d.Key == id);
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