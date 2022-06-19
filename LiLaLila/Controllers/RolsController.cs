using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LiLaLila.Controllers
{
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    public class RolsController : ApiController
    {
        RolsService service = new RolsService();
       [HttpPost]
        public bool UserAdmin(RolsDTO admin)
        {
           return  service.UserAdmin(admin);
        }


     // [HttpPost]
     //public IHttpActionResult setAdmin(RolsDTO admin)
     //   {
     //       if (admin == null)
     //           return NotFound();
     //       return Ok(service.setAdmin(admin));
     //   }

    }
}
