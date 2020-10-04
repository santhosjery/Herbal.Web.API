using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using yah_varmalayam.API.Models;

namespace yah_varmalayam.API.Controllers
{
    public class UserController : HerbalApiControllerBase
    {
        public bool Get()
        {
            return true;
        }
        public bool Post(AppUser appUser)
        {
            try
            {
                dbContext.AppUsers.Add(appUser);
                dbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
