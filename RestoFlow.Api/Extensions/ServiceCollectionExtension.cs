using RestoFlow.Core.Common;
using RestoFlow.Core.Contracts;

namespace RestoFlow.Api.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            return services;
        }
    }
}
