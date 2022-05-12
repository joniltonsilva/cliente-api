using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Clientes.Biblioteca.Interfaces
{
    public interface IBaseEntidadeRepositorio<TEntity> where TEntity : class
    {
        Task Adicionar(TEntity entity);
        Task Atualizar(TEntity entity);
        Task Delete(int id);
        IQueryable<TEntity> IQueryable(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order = null);
        TEntity Recuperar(int id);
    }
}