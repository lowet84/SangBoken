using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SangBokenAPI.DataAccess;
using SangBokenAPI.Models;

namespace SangBokenAPI.Controllers
{
    [AllowCrossSiteJson]
    public class SongInSongBookController : ApiController
    {
        private readonly SongInSongBookAccessor _accessor = new SongInSongBookAccessor();

        // GET: api/SongInSongBook/5
        public int[] Get(int id)
        {
            return _accessor.GetSongsInSongBook(id);
        }

        // PUT: api/SongInSongBook/5
        public void Put(int id, [FromBody]int[] value)
        {
            _accessor.UpdateSongInSongBook(id,value);
        }
    }
}
