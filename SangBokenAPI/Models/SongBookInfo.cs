﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SangBokenAPI.Models
{
    public class SongBookInfo
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int[] Songs { get; set; }
    }
}