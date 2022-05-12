using Clientes.Biblioteca.Interfaces;
using Clientes.Biblioteca.Persistencia;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading;
using System.Threading.Tasks;

namespace Clientes.Biblioteca.UnidadeDeTrabalho
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseFacade _database;
        public UnitOfWork(ClienteDbContext dbContext)
        {
            _database = dbContext.Database;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken)
        {
            return await _database.BeginTransactionAsync(cancellationToken).ConfigureAwait(false);
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
