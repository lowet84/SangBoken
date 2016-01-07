using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SangBoken.Model;

namespace SangBoken.Context
{
    public class SangBokenContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public DbSet<SongBook> SongBooks { get; set; }
    }
}
