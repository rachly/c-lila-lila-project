using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL
{
    public class TypeProductService
    {
        public List<TypeProductDTO> GetAllTypesP()
        {
            using (LilelileEntities db = new LilelileEntities())
            {
                var p = db.TypeProduct.ToList();
                return MapperGlobal.mapper.Map<List<TypeProductDTO>>(db.TypeProduct);
            }
        }
        public TypeProductDTO SetType(TypeProductDTO TypeDTO)
        {
            using (LilelileEntities db = new LilelileEntities())
            {
                TypeProduct newType = MapperGlobal.mapper.Map<TypeProduct>(TypeDTO);
                newType = db.TypeProduct.Add(newType);
                db.SaveChanges();
                return MapperGlobal.mapper.Map<TypeProductDTO>(newType);
            }
        }
    }
}