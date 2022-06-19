using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL
{
    public class SupplierService
    {
        public List<SpuplierDTO> GetAllSuplier()
        {
            using (LilelileEntities db = new LilelileEntities())
            {
                var p = db.Suppliers.ToList();
                return MapperGlobal.mapper.Map<List<SpuplierDTO>>(db.Suppliers);
            }
        }
        public SpuplierDTO SetSuppiler(SpuplierDTO SupilerDTO)
        {
            using (LilelileEntities db = new LilelileEntities())
            {
                Suppliers newSuppiler = MapperGlobal.mapper.Map<Suppliers>(SupilerDTO);
                newSuppiler = db.Suppliers.Add(newSuppiler);
                db.SaveChanges();
                return MapperGlobal.mapper.Map<SpuplierDTO>(newSuppiler);
            }
        }


    }
    }