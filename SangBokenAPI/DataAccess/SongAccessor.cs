using System;
using System.Collections.Generic;
using System.IO;
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
            var ret = Context.Songs.Select(d => new SongInfo
            {
                Id = d.Key,
                Name = d.Name,
                Line = d.Text
            }).ToList();
            ret.ForEach(d => d.Line = d.Line == null ? null : new StringReader(d.Line).ReadLine());
            return ret;
        }

        // GET: api/Song/5
        public SongInfo GetSong(int id)
        {
            var song = Context.Songs.SingleOrDefault(d => d.Key == id);
            return new SongInfo { Id = song.Key, Line = song.Text, Name = song.Name };
        }

        // POST: api/Song
        public void AddSong(SongInfo value)
        {
            using (var context = Context)
            {
                var song = new Song { Name = value.Name, Text = value.Line };
                context.Songs.Add(song);
                context.SaveChanges();
            }
        }

        // PUT: api/Song/5
        public void UpdateSong(int id, SongInfo value)
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