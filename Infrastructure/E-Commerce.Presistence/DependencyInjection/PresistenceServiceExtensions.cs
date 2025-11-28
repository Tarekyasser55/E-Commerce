using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Presistence.Context;
using E_Commerce.Presistence.DbInitializers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace E_Commerce.Presistence.DependencyInjection;

public static class PresistenceServiceExtensions 
{
    public static IServiceCollection AddPresistenceServices(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<AplicationDbContext>(options =>
        {
            var connection = configuration.GetConnectionString("SQLConnection");
            options.UseSqlServer(connection);
        });
        services.AddScoped<IUnitOfWork, IUnitOfWork>();
        services.AddScoped<IDbInitializer, DbInitializer>();
        return services;
        //don
    }
}
