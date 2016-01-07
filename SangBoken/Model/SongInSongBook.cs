using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SangBoken.Model
{
    public class SongInSongBook
    {
        [Key, Column(Order = 0), ForeignKey("Song")]
        public int SongKey { get; set; }

        [Key, Column(Order = 1), ForeignKey("SongBook")]
        public int SongBookKey { get; set; }
    }
}
