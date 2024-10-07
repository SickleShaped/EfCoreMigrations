using EfCoreMigrations.DB;
using EfCoreMigrations.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Repositories
{
    public class TripRepository:ITripRepository
    {
        private readonly ApiDbContext _dbContext;
        public TripRepository(ApiDbContext apiDbContext)
        {
            _dbContext = apiDbContext;
        }

        public async Task<List<TripEntity>> GetAll()
        {
            return await _dbContext.Trips.AsNoTracking().ToListAsync();
        }
        public async Task<TripEntity> GetById(Guid Id)
        {
            return await _dbContext.Trips.AsNoTracking().Where(c=>c.Id ==  Id).FirstOrDefaultAsync();
        }
        public async Task<List<PlaneTripEntity>> GetPlaneTrips()
        {
            return await _dbContext.PlaneTrips.AsNoTracking().ToListAsync();
        }
        public async Task InsertTrip(TripEntity creation)
        {
            TripEntity entity = new TripEntity();
            entity.Id = Guid.NewGuid();
            entity.Plane = creation.Plane;
            entity.TimeOut = creation.TimeOut;
            entity.TimeIn = creation.TimeIn;
            entity.CompanyId = creation.CompanyId;
            entity.TownFrom = creation.TownFrom;
            entity.TownTo = creation.TownTo;

            await _dbContext.Trips.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task InsertPlaneTrip(PlaneTripEntity creation)
        {
            PlaneTripEntity entity = new PlaneTripEntity();
            entity.Id = Guid.NewGuid();
            entity.Plane = creation.Plane;
            entity.TimeOut = creation.TimeOut;
            entity.TimeIn = creation.TimeIn;
            entity.CompanyId = creation.CompanyId;
            entity.TownFrom = creation.TownFrom;
            entity.TownTo = creation.TownTo;
            entity.Plane = creation.Plane;

            await _dbContext.PlaneTrips.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateTrip(TripEntity trip, Guid Id, int? PlaneId)
        {
            if (PlaneId != null)
            {
                var x = await _dbContext.Trips.AsNoTracking().Where(c => c.Id == Id).FirstOrDefaultAsync();
                x.Plane = trip.Plane;
                x.TimeOut = trip.TimeOut;
                x.TimeIn = trip.TimeIn;
                x.CompanyId = trip.CompanyId;
            }
            else
            {
                var x = await _dbContext.PlaneTrips.AsNoTracking().Where(c => c.Id == Id).FirstOrDefaultAsync();
                x.PlaneId = (int)PlaneId;
                x.Plane = trip.Plane;
                x.TimeOut = trip.TimeOut;
                x.TimeIn = trip.TimeIn;
                x.CompanyId = trip.CompanyId;
            }
            
        }
        public async Task DeleteTrip(Guid Id)
        {
            var res = await _dbContext.Trips.Where(u => u.Id == Id).ExecuteDeleteAsync();
        }
    }
}
