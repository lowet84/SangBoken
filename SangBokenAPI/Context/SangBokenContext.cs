using System.Data.Entity;
using SangBokenAPI.Models;

namespace SangBokenAPI.Context
{
    public class SangBokenContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public DbSet<SongBook> SongBooks { get; set; }
    }
}
