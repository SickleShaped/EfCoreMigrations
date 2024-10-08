using EfCoreMigrations.DB;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Services.Implementations;

public class TripService<T> : ITripService<T> where T:TripEntity
{
    private readonly ApiDbContext _context;
    public TripService(ApiDbContext dbContext)
    {
        _context = dbContext;
    }

    public async Task<List<T>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<T> GetById(Guid Id)
    {
        var x = await _context.Trips.Where(t=>t.Id == Id).FirstOrDefaultAsync();
        return (T)x;
    }

    public async Task Insert(T entity)
    {
        await _context.Trips.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task InsertPlaneTrip(PlaneTripEntity entity)
    {
        await _context.Trips.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        await _context.Trips.Where(c => c.Id == id).ExecuteDeleteAsync();
    }

}
