using EfCoreMigrations.DB;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Services.Implementations;

public class PassengerService<T> : IPassengerService<T>
{
    private readonly ApiDbContext _context;
    public  PassengerService(ApiDbContext dbContext)
    {
        _context = dbContext;
    }
    public async Task<List<T>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<T> GetById(Guid Id)
    {
        throw new NotImplementedException();
    }

    public async Task Insert(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task InsertVipPassenger(VipPassengerCreationDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(Guid id)
    {
        await _context.Passengers.Where(c => c.Id == id).ExecuteDeleteAsync();
    }
}
