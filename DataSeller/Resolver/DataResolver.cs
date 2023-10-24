using DataSeller.Implementations;
using DataSeller.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DataSeller.Resolver
{
    public static class DataResolver
    {
        public static IServiceCollection AddDataResolver(this IServiceCollection services)
        {
            services.AddScoped<IProductCategoryData, ProductCategoryData>();
            return services;
        }
    }
}
