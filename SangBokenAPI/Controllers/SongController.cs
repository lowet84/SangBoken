using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using SangBokenAPI.DataAccess;
using SangBokenAPI.Models;

namespace SangBokenAPI.Controllers
{
    public class SongController : ApiController
    {
        private readonly SongAccessor _accessor = new SongAccessor();

        // GET: api/Song
        [AllowCrossSiteJson]
        public IEnumerable<SongInfo> Get()
        {
            return _accessor.GetAllSongs();
        }

        // GET: api/Song/5
        [AllowCrossSiteJson]
        public SongInfo Get(int id)
        {
            return _accessor.GetSong(id);
        }

        // POST: api/Song
        [AllowCrossSiteJson]
        public int Post([FromBody]SongInfo value)
        {
            return _accessor.AddSong(value);
        }

        // PUT: api/Song/5
        [AllowCrossSiteJson]
        public void Put(int id, [FromBody]SongInfo value)
        {
            _accessor.UpdateSong(id,value);
        }

        // DELETE: api/Song/5
        [AllowCrossSiteJson]
        public void Delete(int id)
        {
            _accessor.DeleteSong(id);
        }
    }
}
