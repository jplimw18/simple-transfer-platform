using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleTransferPlatform.Domain.Interfaces;
using SimpleTransferPlatform.Persistence.Context;
using SimpleTransferPlatform.Persistence.Repository;

namespace SimpleTransferPlatform.Persistence;

public static class ServicesExtensions
{
    public static void ConfigurePersistanceApp(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("dev");
        services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ICommonRepository, CommonRepository>();
        services.AddScoped<IShopkeeperRepository, ShopkeeperRepository>();
    }
}