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
    public class UserController : ApiController
    {
        UserService service = new UserService();
        
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       
       /// TODO שכחתי לבדוק תקינות
        public List<UserDTO> Get()
        {
            return service.getAllUsers();
        }
        [HttpPost]
        public IHttpActionResult update(UserDTO userDTO)
        {
            if (userDTO == null)
                return NotFound();
            return Ok( service.SetUser(userDTO));
        }
        [HttpPut]
        public IHttpActionResult Put(UserDTO userDTO)
        {
            return Ok(service.UpdateUser(userDTO));
        }
        [HttpPost]
        [Route("~/api/User/UserAdmin")]

        public bool UserAdmin(UserDTO admin)
        {
            return service.UserAdmin(admin);
        }



    }
}
