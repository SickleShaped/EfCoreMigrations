using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;

namespace EfCoreMigrations.Repositories
{
    public interface IDbRepository
    {
        Task<List<CompanyEntity>> GetCompanies();
        Task<List<StateOwnedCompanyEntity>> GetStateOwnedCompanies();
        Task<List<PassengerEntity>> GetPassengers();
        Task<List<VipPassengerEntity>> GetVipPassengers();
        Task<List<TripEntity>> GetTrips();
        Task<List<PlaneTripEntity>> GetPlaneTrips();
        Task InsertCompanyEntity(CompanyCreationDto entity);
        Task InsertStateOwnedCompany(StateOwnedCompanyCreationDto entity);
        Task InsertTripEntity(TripCreationDto entity);
        Task InsertPlaneTripEntity(PlaneTripCreationDto entity);
        Task InsertPassengerEntity(PassengerCreationDto entity);
        Task InsertVipPassengerEntity(VipPassengerCreationDto entity);
    }
}




//var a = (IEnumerable<Users>)_context.Users.Where(u => u.Id > 1);
//a.Where(x).ToList();
//