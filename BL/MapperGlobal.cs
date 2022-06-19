using AutoMapper;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class MapperGlobal
    {
        public static IMapper mapper;
        static MapperGlobal()
        {

           
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<ProductsDTO, Products>();
                cfg.CreateMap<Products, ProductsDTO>().ForMember(dest => dest.Photo, opt => opt.MapFrom(src => src.Images.Filevalue));;
                cfg.CreateMap<TypeProduct, TypeProductDTO>();
                cfg.CreateMap<TypeProductDTO,TypeProduct>();
                cfg.CreateMap<SpuplierDTO, Suppliers>();
                cfg.CreateMap< Suppliers,SpuplierDTO>();
                cfg.CreateMap<Images, ImageDTO>();
                cfg.CreateMap< ImageDTO,Images> ();
                cfg.CreateMap<Roles, RolsDTO>();
                cfg.CreateMap< RolsDTO,Roles>();
            });
            mapper = config.CreateMapper();
        }
    }
}
