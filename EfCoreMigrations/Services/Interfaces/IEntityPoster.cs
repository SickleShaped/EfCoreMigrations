using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;

namespace EfCoreMigrations.Services.Interfaces;

public interface IEntityPoster
{
    Task InsertCompanyEntity(CompanyCreationDto entity);
    Task InsertStateOwnedCompany(StateOwnedCompanyCreationDto entity);
    Task InsertTripEntity(TripCreationDto entity);
    Task InsertPlaneTripEntity(PlaneTripCreationDto entity);
    Task InsertPassengerEntity(PassengerCreationDto entity);
    Task InsertVipPassengerEntity(VipPassengerCreationDto entity);

}
