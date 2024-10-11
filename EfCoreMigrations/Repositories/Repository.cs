using EfCoreMigrations.DB.Entities.Abstractions;
using EfCoreMigrations.DB;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EfCoreMigrations.Repositories;
public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : EntityBase
{
    protected readonly ApiDbContext _context;
    protected readonly DbSet<TEntity> _dbSet;

    public Repository(ApiDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public void Insert(TEntity entity)
    {
        _dbSet.Add(entity);
    }

    public async Task<int> ExecuteDeleteAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken)
    {
        return await _dbSet.Where(predicate).ExecuteDeleteAsync(cancellationToken);
    }

    public IQueryable<TEntity> GetAll()
    {
        return _dbSet;
    }

    public async Task<TEntity> GetByIdAsync(Guid id, bool trackable,  CancellationToken cancellationToken)
    {
        if (trackable)
        {
            return await _dbSet.Where(x =>x.Id == id).FirstOrDefaultAsync(cancellationToken);
        }
        else
        {
            return await _dbSet.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync(cancellationToken);
        }
    }

}
