﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SangBoken.Model
{
    public abstract class ModelBase
    {
        [Key]
        public int Key { get; set; }
    }
}
