using BL;
using DTO;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LiLaLila.Controllers
{
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    public class TypeProductController : ApiController
    {
        TypeProductService serviceTypeP = new TypeProductService();
        [HttpGet]
        public List<TypeProductDTO> GetAllTypesProu()
        {
            return serviceTypeP.GetAllTypesP();
        }

        [HttpPost]
        public IHttpActionResult setTypes(TypeProductDTO TypeDTO)
        {
            if (TypeDTO == null)
                return NotFound();
            return Ok(serviceTypeP.SetType(TypeDTO));
        }

    }
}
