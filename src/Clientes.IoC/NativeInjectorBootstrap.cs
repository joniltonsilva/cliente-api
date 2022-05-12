using Clientes.Biblioteca.Interfaces;
using Clientes.Biblioteca.Persistencia;
using Clientes.Migracoes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Clientes.IoC
{
    public static class NativeInjectorBootstrap
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextFactory<ClienteDbContext>(options => MapSqliteDbOptions(options, configuration));
            services.AddDbContext<ClienteDbContext>(options => MapSqliteDbOptions(options, configuration));

            services.AddScoped<IUnitOfWork>(provider => provider.GetService<ClienteDbContext>());
        }

        private static void MapSqliteDbOptions(DbContextOptionsBuilder options, IConfiguration configuration)
        {
            options.UseSqlite(
                        configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(ClientesMigracoesContext).Assembly.FullName));
        }
    }
}
