using EfCoreMigrations.DB.Entities.Abstractions;
using System.Linq.Expressions;

namespace EfCoreMigrations.Repositories;

public interface IRepository<TEntity> where TEntity : EntityBase
{
    IQueryable<TEntity> GetAll();
    Task<TEntity> GetByIdAsync(Guid id, bool trackable, CancellationToken cancellationToken);
    void Insert(TEntity entity);
    Task<int> ExecuteDeleteAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);
    Task<List<TEntity>> GetAllWhereExpression(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);
    //update
}
