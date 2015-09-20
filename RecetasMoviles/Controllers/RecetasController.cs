using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RecetasMoviles.Controllers
{
    public class RecetasController : ApiController
    {
        public int Get()
        {
            Random random = new Random();
            int value = random.Next(100, 10000);

            return value;
        }
    }
}
