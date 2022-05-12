using Clientes.Biblioteca.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading;
using System.Threading.Tasks;

namespace Clientes.Biblioteca.Persistencia
{
    public class ClienteDbContext : DbContext, IUnitOfWork
    {
        public ClienteDbContext(DbContextOptions<ClienteDbContext> options)
         : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken)
        {
            return await Database.BeginTransactionAsync(cancellationToken).ConfigureAwait(false);
        }

        public async Task EndTransactionAsync(IDbContextTransaction transaction, CancellationToken cancellationToken)
        {
            await transaction.CommitAsync(cancellationToken).ConfigureAwait(false);
        }

        public async Task RollbackTransactionAsync(IDbContextTransaction transaction, CancellationToken cancellationToken)
        {
            await transaction.RollbackAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
