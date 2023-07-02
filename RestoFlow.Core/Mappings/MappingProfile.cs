using AutoMapper;

using RestoFlow.Core.Models.Category;
using RestoFlow.Core.Models.Order;
using RestoFlow.Core.Models.Product;
using RestoFlow.Core.Models.Reservation;
using RestoFlow.Core.Models.Table;
using RestoFlow.Core.Models.User;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // User
            CreateMap<ApplicationUser, UserDTO>();
            CreateMap<UserDTO, ApplicationUser>();

            CreateMap<ApplicationUser, RegisterDTO>();
            CreateMap<RegisterDTO, ApplicationUser>();

            // Product
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();

            CreateMap<Product, ProductCreateDTO>();
            CreateMap<ProductCreateDTO, Product>();

            CreateMap<Product, ProductCreateDTO>();
            CreateMap<ProductCreateDTO, Product>();

            CreateMap<Product, ProductEditDTO>();
            CreateMap<ProductEditDTO, Product>();

            // Category
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();

            // Order
            CreateMap<Order, OrderCreateDTO>();
            CreateMap<OrderCreateDTO, Order>();

            CreateMap<OrderDTO, OrderCreateDTO>();
            CreateMap<OrderCreateDTO, OrderDTO>();

            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();

            CreateMap<Order, OrderUpdateDTO>();
            CreateMap<OrderUpdateDTO, Order>();

            // Table
            CreateMap<Table, TableDTO>();
            CreateMap<TableDTO, Table>();

            CreateMap<Table, TableCreateDTO>();
            CreateMap<TableCreateDTO, Table>();

            CreateMap<Table, TableUpdateDTO>();
            CreateMap<TableCreateDTO, Table>();


            // Reservation
            CreateMap<Reservation, ReservationDTO>();
            CreateMap<ReservationDTO, Reservation>();

            CreateMap<Reservation, ReservationCreateDTO>();
            CreateMap<ReservationCreateDTO, Reservation>();

            CreateMap<Reservation, ReservationEditDTO>();
            CreateMap<ReservationEditDTO, Reservation>();
        }
    }
}
