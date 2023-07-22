using RestoFlow.Core.Common;
using RestoFlow.Core.Contracts;
using RestoFlow.Core.Services;

namespace RestoFlow.Api.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<TokenService, TokenService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ITableService, TableService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IBillService, BillService>();
            services.AddScoped<IStorageService, StorageService>();
            services.AddScoped<IAwsCredentialsService, AwsCredentialsService>();



            return services;
        }

    }
}
