using AutoMapper;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO;

namespace EfCoreMigrations.Services;

public class AppMapingProfile : Profile
{
    public AppMapingProfile()
    {
        CreateMap<CompanyEntity, Company>().ReverseMap();
        CreateMap<PassengerEntity, Passenger>().ReverseMap();
        CreateMap<TripEntity, Trip>().ReverseMap();

        /*
        CreateMap<TripEntity, TripCreationDto>().ReverseMap();
        CreateMap<PlaneTripEntity, PlaneTripCreationDto>().ReverseMap();
        CreateMap<PassengerEntity, PassengerCreationDto>().ReverseMap();
        CreateMap<VipPassengerEntity, VipPassengerCreationDto>().ReverseMap();
        CreateMap<StateOwnedCompanyEntity, StateOwnedCompanyCreationDto>().ReverseMap();
        CreateMap<CompanyEntity, CompanyCreationDto>().ReverseMap();
        */

    }

}
