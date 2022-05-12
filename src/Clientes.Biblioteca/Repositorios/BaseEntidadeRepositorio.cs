using Clientes.Biblioteca.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Clientes.Biblioteca.Repositorios
{
    public class BaseEntidadeRepositorio<TEntity> : IBaseEntidadeRepositorio<TEntity> where TEntity : class
    {
        protected DbSet<TEntity> EntitySet { get; private set; }

        public BaseEntidadeRepositorio(IClienteDbContext dbContext)
        {
            EntitySet = dbContext.Set<TEntity>();
        }

        public TEntity Recuperar(int id)
        {
            return EntitySet.Find(id);
        }

        public IQueryable<TEntity> IQueryable(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order = null)
        {
            IQueryable<TEntity> query = EntitySet;

            if (where != null)
                query = query.Where(where);

            if (order != null)
                query = order(query);

            return query;
        }

        public async Task Adicionar(TEntity entity)
        {
            await EntitySet.AddAsync(entity).ConfigureAwait(false);
        }

        public async Task Atualizar(TEntity entity)
        {
            _ = await Task.Run(() => EntitySet.Update(entity)).ConfigureAwait(false);
        }

        public async Task Delete(int id)
        {
            _ = await Task.Run(() => EntitySet.Remove(Recuperar(id))).ConfigureAwait(false);
        }
    }
}
