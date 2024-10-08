using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO;
using EfCoreMigrations.DTO.CreationDto;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Repositories.Interfaces;

public interface ITripRepository<T> : IBaseRepository<TripEntity, TripCreationDto>
{
    Task<List<PlaneTripEntity>> GetPlaneTrips();
    Task InsertPlaneTrip(PlaneTripCreationDto entity);
    Task Edit(TripCreationDto dto, VipStatus vipStatus);

}
