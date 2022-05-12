using Clientes.Aplicacao.Clientes.AutoMapper;
using Clientes.Biblioteca.Interfaces;
using Clientes.Biblioteca.Persistencia;
using Clientes.Biblioteca.UnidadeDeTrabalho;
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

            services.AddScoped<IClienteDbContext>(provider => provider.GetService<ClienteDbContext>());
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddAutoMapper(typeof(ClienteProfile));
        }

        private static void MapSqliteDbOptions(DbContextOptionsBuilder options, IConfiguration configuration)
        {
            options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
