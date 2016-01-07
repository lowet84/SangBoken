using System.Collections.Generic;

namespace SangBokenAPI.Models
{
    public class SongBook : ModelBase
    {
        public string Name { get; set; }
        public List<SongInSongBook> Songs { get; set; }
    }
}