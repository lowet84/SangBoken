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
    public class SongSearchController : ApiController
    {
        private readonly SongSearchAccessor _accessor = new SongSearchAccessor();

        // GET: api/SongSearch/5
        public SongInfo[] Get(string id)
        {
            return _accessor.FindSongs(id);
        }
    }
}
