using System.Collections.Generic;
using System.Linq;

namespace SangBokenAPI.Models
{
    public class SongBook : ModelBase
    {
        public string Name { get; set; }
        public List<SongInSongBook> Songs { get; set; }

        public override void Update(object newObject)
        {
            var newSongBook = newObject as SongBookInfo;
            if (newSongBook == null) return;
            Name = newSongBook.Name;
            Songs = newSongBook.Songs.Select(d => new SongInSongBook {SongKey = d, SongBookKey = Key}).ToList();
        }
    }
}