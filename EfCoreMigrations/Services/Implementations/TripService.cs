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
        var result = await _context.Trips.ToListAsync();
        return new List<T>((IEnumerable<T>)result);
    }

    public async Task<T> GetById(Guid Id)
    {
        var result = await _context.Trips.Where(t=>t.Id == Id).FirstOrDefaultAsync();
        return (T)result;
    }

    public async Task<List<PlaneTripEntity>> GetPlaneTrips()
    {
        return await _context.PlaneTrips.ToListAsync();
    }

    public async Task<PlaneTripEntity> GetPlaneTipById(Guid id)
    {
        return await _context.PlaneTrips.Where(t => t.Id == id).FirstOrDefaultAsync();
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

    public async Task Save()
    {
        await _context.SaveChangesAsync();
    }

}
