using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using SangBokenAPI.Controllers;
using SangBokenAPI.Models;

namespace SangBokenAPI.DataAccess
{
    public class SongAccessor : AccessorBase
    {
        public IEnumerable<SongInfo> GetAllSongs()
        {
            return Context.Songs.Select(d => new SongInfo {Id = d.Key, Name = d.Name}).ToList();
        }

        // GET: api/Song/5
        public Song GetSong(int id)
        {
            return Context.Songs.SingleOrDefault(d => d.Key == id);
        }

        // POST: api/Song
        public void AddSong(Song value)
        {
            using (var context = Context)
            {
                value.Key = 0;
                context.Songs.Add(value);
                context.SaveChanges();
            }
        }

        // PUT: api/Song/5
        public void UpdateSong(int id, Song value)
        {
            using (var context = Context)
            {
                var existing = context.Songs.SingleOrDefault(d => d.Key == id);
                existing?.Update(value);
                context.SaveChanges();
            }
        }

        // DELETE: api/Song/5
        public void DeleteSong(int id)
        {
            using (var context = Context)
            {
                var existing = context.Songs.SingleOrDefault(d => d.Key == id);
                if (existing == null) return;
                context.Songs.Remove(existing);
                context.SaveChanges();
            }
        }
    }
}