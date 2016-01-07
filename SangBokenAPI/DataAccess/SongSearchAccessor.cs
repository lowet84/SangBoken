using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SangBokenAPI.Models;

namespace SangBokenAPI.DataAccess
{
    public class SongSearchAccessor : AccessorBase
    {
        public SongInfo[] FindSongs(string value)
        {
            return new SongAccessor()
                .GetAllSongs()
                .Where(d => d.Name.ToLower().Contains(value.ToLower()) || (d.Line != null && d.Line.ToLower().Contains(value.ToLower())))
                .ToArray();
        }
    }
}