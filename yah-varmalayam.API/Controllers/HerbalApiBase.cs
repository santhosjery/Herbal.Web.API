using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using yah_varmalayam.API.Models;

namespace yah_varmalayam.API.Controllers
{
    public class HerbalApiControllerBase : ApiController
    {
        protected HerbalEntities dbContext = new HerbalEntities();
        
    }
}
