using Clientes.Biblioteca.Interfaces;
using Clientes.Biblioteca.Repositorios;
using Clientes.Dominio.Clientes.Entidades;
using Clientes.Dominio.Clientes.Repositorios;

namespace Clientes.Infra.Clientes.Repositorios
{
    public class ClienteRepositorio : BaseEntidadeRepositorio<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(IClienteDbContext dbContext) : base(dbContext)
        {
        }
    }
}
