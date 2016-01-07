using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SangBokenAPI.Models
{
    public class SongInSongBook
    {
        [Key, Column(Order = 0), ForeignKey("Song")]
        public int SongKey { get; set; }
        public Song Song { get; set; }

        [Key, Column(Order = 1), ForeignKey("SongBook")]
        public int SongBookKey { get; set; }
        public SongBook SongBook { get; set; }
    }
}
