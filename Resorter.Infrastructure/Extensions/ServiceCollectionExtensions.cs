using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Resorter.Application.Interfaces;
using Resorter.Infrastructure.Persistence;
using Resorter.Infrastructure.Repositories;
using Resorter.Infrastructure.Seeder;

namespace Resorter.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<ResorterDbContext>(options => options.UseSqlServer(connectionString));

        services.AddScoped<IPropertyRepository, PropertyRepository>();
        services.AddScoped<IResorterSeeder, ResorterSeeder>();
    }
}
