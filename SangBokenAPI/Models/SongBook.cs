using System.Collections.Generic;

namespace SangBokenAPI.Models
{
    public class SongBook : ModelBase
    {
        public string Name { get; set; }
        public List<SongInSongBook> Songs { get; set; }

        public override void Update(object newObject)
        {
            var newSongBook = newObject as SongBook;
            if (newSongBook == null) return;
            Name = newSongBook.Name;
        }
    }
}