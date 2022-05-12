using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading;
using System.Threading.Tasks;

namespace Clientes.Biblioteca.Interfaces
{
    public interface IUnitOfWork
    {
        Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken);

        Task EndTransactionAsync(IDbContextTransaction transaction, CancellationToken cancellationToken);

        Task RollbackTransactionAsync(IDbContextTransaction transaction, CancellationToken cancellationToken);
    }
}
