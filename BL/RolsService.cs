using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public class RolsService
    {

        public RolsDTO setAdmin(RolsDTO admin)
        {
            using (LilelileEntities db = new LilelileEntities())
            {
                Roles newAdmin = MapperGlobal.mapper.Map<Roles>(admin);
                newAdmin = db.Roles.Add(newAdmin);
                db.SaveChanges();
                return MapperGlobal.mapper.Map<RolsDTO>(newAdmin);
            }
        }

        public RolsDTO UpdateAdmin(RolsDTO admin)
        {
            using (LilelileEntities db = new LilelileEntities())
            {
                Roles newadmin = db.Roles.FirstOrDefault(x => x.Id == admin.Id);
                if (newadmin != null)
                {
                    newadmin.Id = admin.Id;
                    newadmin.Name = admin.Name;

                }
                db.SaveChanges();
                return MapperGlobal.mapper.Map<RolsDTO>(newadmin);
            }
        }




          public bool UserAdmin(RolsDTO admin)
        {
           using (LilelileEntities db = new LilelileEntities())
         {
               Roles newadmin = db.Roles.FirstOrDefault(x => x.Id == admin.Id && x.Name==admin.Name);
              if (newadmin != null)
              {
                   return true;
                }
   
         }
            return false;
       }

    }
}

