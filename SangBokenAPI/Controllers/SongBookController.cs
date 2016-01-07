﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SangBokenAPI.DataAccess;
using SangBokenAPI.Models;

namespace SangBokenAPI.Controllers
{
    public class SongBookController : ApiController
    {
        private readonly SongBookAccessor _accessor = new SongBookAccessor();

        // GET: api/SongBook
        public IEnumerable<SongBookInfo> Get()
        {
            return _accessor.GetAllSongBooks();
        }

        // GET: api/SongBook/5
        public SongBook Get(int id)
        {
            return _accessor.GetSongBook(id);
        }

        // POST: api/SongBook
        public void Post([FromBody]SongBook value)
        {
            _accessor.AddSongBook(value);
        }

        // PUT: api/SongBook/5
        public void Put(int id, [FromBody]SongBook value)
        {
            _accessor.UpdateSongBook(id,value);
        }

        // DELETE: api/SongBook/5
        public void Delete(int id)
        {
            _accessor.DeleteSongBook(id);
        }
    }
}