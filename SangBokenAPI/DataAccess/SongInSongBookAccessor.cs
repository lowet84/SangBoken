using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SangBokenAPI.Models;

namespace SangBokenAPI.DataAccess
{
    public class SongInSongBookAccessor : AccessorBase
    {
        public int[] GetSongsInSongBook(int id)
        {
            return
                Context.SongBooks.Include("Songs")
                    .SingleOrDefault(d => d.Key == id)?
                    .Songs.Select(d => d.SongKey)
                    .ToArray();
        }

        public void UpdateSongInSongBook(int id, int[] value)
        {
            using (var context = Context)
            {
                var existing = context.SongBooks.Include("Songs").SingleOrDefault(d => d.Key == id);
                if (existing == null)
                    throw new KeyNotFoundException("No songbook with id " + id);
                existing.Songs.Clear();
                value.ToList().ForEach(d => existing.Songs.Add(new SongInSongBook { SongBookKey = id, SongKey = d }));
                context.SaveChanges();
            }
        }
    }
}