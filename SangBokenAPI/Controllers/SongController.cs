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
    public class SongController : ApiController
    {
        private readonly SongAccessor _accessor = new SongAccessor();

        // GET: api/Song
        public IEnumerable<SongInfo> Get()
        {
            return _accessor.GetAllSongs();
        }

        // GET: api/Song/5
        public SongInfo Get(int id)
        {
            return _accessor.GetSong(id);
        }

        // POST: api/Song
        public void Post([FromBody]SongInfo value)
        {
            _accessor.AddSong(value);
        }

        // PUT: api/Song/5
        public void Put(int id, [FromBody]SongInfo value)
        {
            _accessor.UpdateSong(id,value);
        }

        // DELETE: api/Song/5
        public void Delete(int id)
        {
            _accessor.DeleteSong(id);
        }
    }
}
