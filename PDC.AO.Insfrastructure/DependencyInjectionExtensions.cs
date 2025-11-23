using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PDC.AO.Domain.Repositories;
using PDC.AO.Insfrastructure.Data;
using PDC.AO.Insfrastructure.Data.Repositories;
using System.Runtime.CompilerServices;

namespace PDC.AO.Insfrastructure;
public static class DependencyInjectionExtensions
{
    public static void AddInfrastruture(this IServiceCollection services, IConfiguration configuration)
    {
        AddRepositories(services);
        AddDbContext(services, configuration);
    }
    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<IEspecialidadeRepository, EspecialidadeRepository>();
    }

    private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Connection");
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 43));

        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySql(connectionString, serverVersion));
    }
}
