﻿using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.CodeDom.Compiler;

namespace LiLaLila.Controllers
{
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    public class ProductsController : ApiController
    {
        ProductsService serviceP = new ProductsService();
        public List<ProductsDTO> GetAllP(int type)
        {
            return serviceP.GetAllProducts(false,type);
        }
        [Route("api/Products/GetAllPWhithNotActive")]
        public List<ProductsDTO> GetAllPWhithNotActive(int type)
        {
            return serviceP.GetAllProducts(true,type);
        }
        [HttpPost]
          public IHttpActionResult setP(ProductsDTO product)
        {
            if (product == null)
                return NotFound();
            return Ok(serviceP.SetProduct(product));
        }
        [HttpPut]
        public IHttpActionResult UpdateProducts(ProductsDTO product)
        {
            return Ok(serviceP.UpdateProducts(product));
        }

       // [HttpPut]
       // public IHttpActionResult updatePhoto(ProductsDTO product)
       //
          //  if (product == null)
           //     return NotFound();
         //   return Ok(serviceP.UpdateProductPhoto(product));
       // }
       // [HttpPut]
       // public IHttpActionResult updateDate(int id, ProductsDTO product)
       // {
       //     return Ok(serviceP.UpdateProductDateSale(product));
       // }
        /// <summary>
        ///מחיקת מוצר    
        /// </summary>
        /// <returns> הופך אותו ללא שימושי    </returns>
        ///TODO לשאול על ענין ה0?
        [HttpDelete]
        public IHttpActionResult DeleteP(int productId)
        {
            if (productId == 0)
                return NotFound();          
            return Ok(serviceP.DeleteProduct(productId));
        }






    }
}
