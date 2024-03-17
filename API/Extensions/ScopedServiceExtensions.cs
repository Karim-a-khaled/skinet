using Core.Inerfaces;
using Core.Interfaces;
using Infrastructure.Data.Repositories;

namespace API.Extensions;

public static class ScopedServiceExtensions
{
    public static IServiceCollection AddScopedServices(this IServiceCollection services, IConfiguration config)
    {

        services.AddScoped<IProductRepo, ProductRepo>();
        services.AddScoped<IProductTypeRepo, ProductTypeRepo>();
        services.AddScoped<IProductBrandRepo, ProductBrandRepo>();
        services.AddScoped<IBasketRepo, BasketRepo>();

        return services;
    }
}
