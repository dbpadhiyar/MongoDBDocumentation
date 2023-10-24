using EngineSeller.Implementations;
using EngineSeller.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EngineSeller.Resolver
{
    public static class EngineResolver
    {
        public static IServiceCollection AddEngineResolver(this IServiceCollection services)
        {
            services.AddScoped<IProductCategoryEngine, ProductCategoryEngine>();
            return services;
        }
    }
}
