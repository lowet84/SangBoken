using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SangBokenAPI.Context;

namespace SangBokenAPI.DataAccess
{
    public abstract class AccessorBase
    {
        protected SangBokenContext Context => new SangBokenContext();
    }
}