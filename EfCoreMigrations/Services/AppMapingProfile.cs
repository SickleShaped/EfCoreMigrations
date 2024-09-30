using AutoMapper;
using EfCoreMigrations.DTO;
using EfCoreMigrations.Entities;

namespace EfCoreMigrations.Services;

public class AppMapingProfile:Profile
{
    public AppMapingProfile()
    {
        CreateMap<CompanyEntity, Company>().ReverseMap();
        CreateMap<PassengerEntity, Passenger>().ReverseMap();
        CreateMap<TripEntity, Trip>().ReverseMap();
    }
    
}
