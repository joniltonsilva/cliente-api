using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading;
using System.Threading.Tasks;

namespace Clientes.Biblioteca.Interfaces
{
    public interface IClienteDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
