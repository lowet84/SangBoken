using System.Linq;
using SangBokenAPI.Models;

namespace SangBokenAPI.DataAccess
{
    internal class SongBookSearchAccessor : AccessorBase
    {
        public SongBookInfo[] FindSongBooks(string value)
        {
            return
                Context.SongBooks.Where(d => d.Name.ToLower().Contains(value.ToLower()))
                    .Select(d => new SongBookInfo { Name = d.Name, Id = d.Key })
                    .ToArray();
        }
    }
}