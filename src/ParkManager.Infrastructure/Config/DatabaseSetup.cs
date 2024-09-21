using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ParkManager.Infrastructure.DbContexts;

namespace ParkManager.Infrastructure.Config;

public static class DatabaseSetup
{
    public static IServiceCollection ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ParkManagerDbContext>(options =>
        {
            options.UseMySQL(configuration.GetConnectionString("ParkManagerConnectionString"));
        });
        return services;
    }

}
