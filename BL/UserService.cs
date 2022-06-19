using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
   public class UserService
    {
        /// <summary>
        /// רשימת כל המשתמשים
        /// </summary>
        /// <returns>רשימת משתמשים פעילים ממוין</returns>
       // public List<UserDTO> getAllUsers()
     //  {
        //    using(LilelileEntities db=new LilelileEntities())
        //    {
         //       var d = db.User.ToList();
         //     return MapperGlobal.mapper.Map<List<UserDTO>>( db.User);
          //  }
     //   }
        public UserDTO SetUser(UserDTO userDTO)
        {
            using (LilelileEntities db = new LilelileEntities())
            {
                User newUser= MapperGlobal.mapper.Map<User>(userDTO);
                newUser= db.User.Add(newUser);
                db.SaveChanges();
               return MapperGlobal.mapper.Map<UserDTO>(newUser);
            }
        }
        public UserDTO UpdateUser(UserDTO userDTO)
        {
            using (LilelileEntities db = new LilelileEntities())
            {
                User newUser =db.User.FirstOrDefault(x=>x.Id==userDTO.Id);
                if (newUser != null)
                {
                    newUser.LastName = userDTO.LastName;
                }
                db.SaveChanges();
                return MapperGlobal.mapper.Map<UserDTO>(newUser);
            }
        }
        public List<UserDTO> getAllUsers()
        {
           using (LilelileEntities db = new LilelileEntities())
          {
               return MapperGlobal.mapper.Map<List<UserDTO>>(db.User.ToList());
           }
       }
      
        public bool UserAdmin(UserDTO  admin)
        {
            using (LilelileEntities db = new LilelileEntities())
            {
                return db.User.Any(x=>x.Mail==admin.Mail&&x.Password==admin.Password&&x.RolesId==1);
            }
        }
      





    }
}
