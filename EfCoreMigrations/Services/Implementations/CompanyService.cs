using EfCoreMigrations.DB;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Services.Implementations;

public class CompanyService<T>:ICompanyService<T> where T:CompanyEntity
{
    private readonly ApiDbContext _context;
    public CompanyService(ApiDbContext dbContext)
    {
        _context = dbContext;
    }

    public async Task<List<T>> GetAll()
    {
        var result = await _context.Companies.ToListAsync();
        return new List<T>((IEnumerable<T>)result);
    }

    public async Task<T> GetById(Guid Id)
    {
        return (T)await _context.Companies.Where(c=>c.Id == Id).FirstOrDefaultAsync();
    }

    public async Task<List<StateOwnedCompanyEntity>> GetStateOwnedCompanies()
    {
        return await _context.StateOwnedCompanies.ToListAsync();
    }

    public async Task<StateOwnedCompanyEntity> GetStateOwnedCompadyById(Guid id)
    {
        return await _context.StateOwnedCompanies.Where(c => c.Id == id).FirstOrDefaultAsync();
    }

    public async Task Insert(T entity)
    {
        await _context.Companies.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task InsertStateOwnedCompany(StateOwnedCompanyEntity entity)
    {
        await _context.StateOwnedCompanies.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        await _context.Companies.Where(c => c.Id == id).ExecuteDeleteAsync();
    }

    public async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}
