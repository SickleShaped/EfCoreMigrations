using EfCoreMigrations.DB;

namespace EfCoreMigrations.UnitsOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApiDbContext _context;
    public UnitOfWork(ApiDbContext context)
    {
        _context = context;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }
}
