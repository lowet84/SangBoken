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
    public class SongBookSearchController : ApiController
    {
        private readonly SongBookSearchAccessor _accessor = new SongBookSearchAccessor();

        // GET: api/SongBookSearch/5
        public SongBookInfo[] Get(string id)
        {
            return _accessor.FindSongBooks(id);
        }

        //// POST: api/SongBookSearch
        //public void Post([FromBody]string value)
        //{
        //}

    }
}
