using EfCoreMigrations.DB;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Services.Implementations;

public class PassengerService<T> : IPassengerService<T> where T : PassengerEntity
{
    private readonly ApiDbContext _context;
    public  PassengerService(ApiDbContext dbContext)
    {
        _context = dbContext;
    }
    public async Task<List<T>> GetAll()
    {
        var result = await _context.Trips.ToListAsync();
        return new List<T>((IEnumerable<T>)result);
    }

    public async Task<T> GetById(Guid Id)
    {
        var result = await _context.Passengers.Where(p => p.Id == Id).FirstOrDefaultAsync();
        return (T)result;
    }

    public async Task<VipPassengerEntity> GetVipPassengerById(Guid id)
    {
        return await _context.VipPassengers.Where(p=>p.Id == id).FirstOrDefaultAsync();
    }
    public async Task<List<VipPassengerEntity>> GetVipPassengers()
    {
        return await _context.VipPassengers.ToListAsync();
    }

    public async Task Insert(T entity)
    {
        await _context.Passengers.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task InsertVipPassenger(VipPassengerEntity entity)
    {
        await _context.VipPassengers.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        await _context.Passengers.Where(c => c.Id == id).ExecuteDeleteAsync();
    }

    public async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}
