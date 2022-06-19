using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class ProductsDTO
    {
        public int Id { get; set; }
        public string NameProdact { get; set; }
        public Nullable<int> TypeProductId { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> Length { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> height { get; set; }
        public Nullable<int> Weight { get; set; }
        public string DescriptionProduct { get; set; }
        public Nullable<int> Yearsofwarranty { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> salePrice { get; set; }
        public Nullable<System.DateTime> OperatingDate { get; set; }
        public Nullable<int> PhotoId { get; set; }
        public Nullable<int> ImageId { get; set; }
        public Byte[] Photo { get; set; }

        public Nullable<bool> Active { get; set; }
    }
}
