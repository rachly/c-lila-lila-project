using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BL;
using DTO;

namespace LiLaLila.Controllers
{
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    public class SuppilerController : ApiController
    {
       SupplierService  serviceSuppliier = new SupplierService();
        [HttpGet]
        public List<SpuplierDTO> GetAllSpupliers()
        {
           var c=  serviceSuppliier.GetAllSuplier();
            return c;
        }


        [HttpPost]
        public IHttpActionResult setSuppiler(SpuplierDTO SuppilerDTO)
        {
            if (SuppilerDTO == null)
                return NotFound();
            return Ok(serviceSuppliier.SetSuppiler(SuppilerDTO));
        }
    }
}
