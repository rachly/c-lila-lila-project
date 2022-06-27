using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
   public class ProductsService
    {
        /// <summary>
        /// רשימת כל המוצרים
        /// </summary>
        //<returns>מחזירה את כל המוצרים </returns>
        public List<ProductsDTO> GetAllProducts(bool whithnotActive,int type)
       {
            using (LilelileEntities db = new LilelileEntities())
          {
                List<Products> p = db.Products.Where(x =>x.TypeProductId==type && (whithnotActive || x.Active == true)).ToList();
              List<ProductsDTO> f= MapperGlobal.mapper.Map<List<ProductsDTO>>(p);
               return f;
           }
       }
      
       
        /// <summary>
        ///הוספת מוצר  
        /// </summary>
        /// <returns>מוסיפה מוצר מחזירה תמוצר החדש </returns>

        public ProductsDTO SetProduct(ProductsDTO product)
        {
            using (LilelileEntities db = new LilelileEntities())
            {
                Products newProduct = MapperGlobal.mapper.Map<Products>(product);
                newProduct.Active =true;
                newProduct = db.Products.Add(newProduct);
                db.SaveChanges();
                return MapperGlobal.mapper.Map<ProductsDTO>(newProduct);
            }
        }
        
       
        
        public ProductsDTO UpdateProducts(ProductsDTO product)
        {
            using (LilelileEntities db = new LilelileEntities())
            {
                Products newProduct = db.Products.FirstOrDefault(x => x.Id == product.Id);
                if (newProduct != null)
                {
                    newProduct.NameProdact = product.NameProdact;
                    newProduct.OperatingDate = product.OperatingDate;
                    newProduct.DescriptionProduct = product.DescriptionProduct;
                    newProduct.PhotoId = product.PhotoId;
                    newProduct.Price = product.Price;
                    newProduct.salePrice = product.salePrice;
                    newProduct.TypeProductId = product.TypeProductId;
                    newProduct.height = product.height;
                    newProduct.Length = product.Length;
                    newProduct.Weight = product.Weight;
                    newProduct.Width = product.Width;
                    newProduct.ImageId = product.ImageId;
                    newProduct.Yearsofwarranty = product.Yearsofwarranty;
                }
                db.SaveChanges();
                return MapperGlobal.mapper.Map<ProductsDTO>(newProduct);
            }
        }
        /// <summary>
        ///עדכון תאריך    
        /// </summary>
        /// <returns> מעדכן תאריך תפוגת מבצע    </returns>

       

        /// <summary>
        ///מחיקת מוצר    
        /// </summary>
        /// <returns> הופך אותו ללא שימושי    </returns>
        ///TODO לשאול על ענין ה0?
        public ProductsDTO DeleteProduct(int productId)
        {
            using (LilelileEntities db = new LilelileEntities())
            {
                Products newProduct = db.Products.FirstOrDefault(x => x.Id == productId);
                if (newProduct != null)
                {
                    newProduct.Active=false;
                }
                db.SaveChanges();
                return MapperGlobal.mapper.Map<ProductsDTO>(newProduct);
            }
        }
    }
}
