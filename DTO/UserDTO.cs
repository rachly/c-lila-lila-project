using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> RolesId { get; set; }
        public string Password { get; set; }
        public string RolesName { get; set; }
    }
}
