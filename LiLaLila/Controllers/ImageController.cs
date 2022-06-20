using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;


namespace LiLaLila.Controllers
{
    [EnableCors(origins: "*", methods: "*", headers: "*")]
  
   public class ImageController : ApiController
   {
      [HttpPost]
       public HttpResponseMessage uploadImage()
          {
       //string imageName = null;
        var httpReqest = HttpContext.Current.Request;
        // upload image
        var postedFile = httpReqest.Files["Image"];
       //   create custom file
       string imageName= new String(Path.GetFileNameWithoutExtension(postedFile.FileName).Take(10).ToArray()).Replace(" ","-");
         //imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(postedFile.FileName);
          //var filePath = HttpContext.Current.Server.MapPath("~/Images/" + imageName);
            //postedFile.SaveAs(postedFile.InputStream);
            // StreamReader sourceStream = new StreamReader(postedFile.InputStream);
            byte[] buffer = new byte[16 * 1024];
            byte[] g;
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = postedFile.InputStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                //return ms.ToArray();
                g = ms.ToArray();
            }
            
           // byte[] fileContents = Encoding.UTF8.GetBytes(postedFile.InputStream);
           // sourceStream.Close();
            //save to DB
            using (LilelileEntities db = new LilelileEntities())
        {
            Images Image = new Images()
            {
             ImageCaption = httpReqest["ImageCaption"],
            NameImage = imageName,
            Filevalue=g
            
        };
                Image = db.Images.Add(Image);
                db.SaveChanges();
                return Request.CreateResponse(Image);
       }
        
        }
      public IHttpActionResult Get()
   {
            using (LilelileEntities db = new LilelileEntities())
            {
                Images Imagef = db.Images.FirstOrDefault();

               // MemoryStream mem = new MemoryStream(Imagef.Filevalue);
                Stream stream = new MemoryStream(Imagef.Filevalue);
               
                HttpResponseMessage response = new HttpResponseMessage();

                response.Content = new StreamContent(stream);
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
                //byte[] byteArray = imageConverter.GetImageAsBytes(@"\filepath-to-image.jpeg");
                List<Byte[]> imageList = new List<Byte[]>();
                imageList.AddRange(db.Images.Select(x => x.Filevalue));
                return Json( imageList );
               
                
            }
        }
       
    }
}
