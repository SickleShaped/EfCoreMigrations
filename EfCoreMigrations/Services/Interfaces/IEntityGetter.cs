using EfCoreMigrations.DB.Entities;

namespace EfCoreMigrations.Services.Interfaces
{
    public interface IEntityGetter
    {
        Task<List<CompanyEntity>> GetCompanies();
        Task<List<StateOwnedCompanyEntity>> GetStateOwnedCompanies();
        Task<List<PassengerEntity>> GetPassengers();
        Task<List<VipPassengerEntity>> GetVipPassengers();
        Task<List<TripEntity>> GetTrips();
        Task<List<PlaneTripEntity>> GetPlaneTrips();
    }
}
