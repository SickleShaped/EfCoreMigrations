using AutoMapper;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO;

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
