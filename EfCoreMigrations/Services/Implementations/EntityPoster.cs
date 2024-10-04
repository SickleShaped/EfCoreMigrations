using EfCoreMigrations.DB;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Services.Interfaces;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace EfCoreMigrations.Services.Implementations
{
    public class EntityPoster:IEntityPoster
    {
        private readonly ApiDbContext _dbContext;

        public EntityPoster(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task InsertCompanyEntity(CompanyCreationDto creation)
        {
            CompanyEntity entity = new CompanyEntity();  
            entity.Id = Guid.NewGuid();
            entity.Name = creation.Name;

            await _dbContext.Companies.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task InsertStateOwnedCompany(StateOwnedCompanyCreationDto creation)
        {
            StateOwnedCompanyEntity entity = new StateOwnedCompanyEntity();
            entity.Name = creation.Name;
            entity.Id = Guid.NewGuid();
            entity.CompanyCountry = creation.CompanyCountry;

            await _dbContext.StateOwnedCompanies.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task InsertTripEntity(TripCreationDto creation)
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
        public async Task InsertPlaneTripEntity(PlaneTripCreationDto creation)
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
        public async Task InsertPassengerEntity(PassengerCreationDto creation)
        {
            PassengerEntity entity = new PassengerEntity();
            entity.Id = Guid.NewGuid();
            entity.Name = creation.Name;

            await _dbContext.Passengers.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task InsertVipPassengerEntity(VipPassengerCreationDto creation)
        {
            VipPassengerEntity entity = new VipPassengerEntity();
            entity.Id = Guid.NewGuid();
            entity.Name = creation.Name;
            entity.VipStatus = creation.VipStatus;

            await _dbContext.VipPassengerEntities.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
