using Core.Inerfaces;
using Infrastructure.Repository;

namespace Extensions;
public static class ScopedServiceExtensions
{
    public static IServiceCollection AddScopedServiceExtensions(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<IProductRepo,ProductRepo>();
        
        return services;
    }
}
