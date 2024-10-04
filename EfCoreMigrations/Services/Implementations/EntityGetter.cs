using EfCoreMigrations.DB;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Services.Implementations
{
    public class EntityGetter : IEntityGetter
    {
        private readonly ApiDbContext _dbContext;
        public EntityGetter(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<CompanyEntity>> GetCompanies()
        {
            return await _dbContext.Companies.AsNoTracking().ToListAsync();
        }
        public async Task<List<StateOwnedCompanyEntity>> GetStateOwnedCompanies()
        {
            return await _dbContext.StateOwnedCompanies.AsNoTracking().ToListAsync();
        }
        public async Task<List<PassengerEntity>> GetPassengers()
        {
            return await _dbContext.Passengers.AsNoTracking().ToListAsync();
        }
        public async Task<List<VipPassengerEntity>> GetVipPassengers()
        {
            return await _dbContext.VipPassengerEntities.AsNoTracking().ToListAsync();
        }
        public async Task<List<TripEntity>> GetTrips()
        {
            return await _dbContext.Trips.AsNoTracking().ToListAsync();
        }
        public async Task<List<PlaneTripEntity>> GetPlaneTrips()
        {
            return await _dbContext.PlaneTrips.AsNoTracking().ToListAsync();
        }
    }
}
