using AutoMapper;
using RestoFlow.Core.Models.Product;
using RestoFlow.Core.Models.User;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserDTO>();
            CreateMap<UserDTO, ApplicationUser>();

            CreateMap<ApplicationUser, RegisterDTO>();
            CreateMap<RegisterDTO, ApplicationUser>();

            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();

            CreateMap<Product, ProductCreateDTO>();
            CreateMap<ProductCreateDTO, Product>();

            CreateMap<Product, ProductCreateDTO>();
            CreateMap<ProductCreateDTO, Product>();

            CreateMap<Product, ProductEditDTO>();
            CreateMap<ProductEditDTO, Product>();
        }
    }
}
