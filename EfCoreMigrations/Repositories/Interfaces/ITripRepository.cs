using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DB.Entities.Abstractions;
using EfCoreMigrations.DTO;
using EfCoreMigrations.DTO.CreationDto;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Repositories.Interfaces;

public interface ITripRepository<T, Y> : IBaseRepository<T, Y> where T : BaseEntity where Y : BaseCreationDto
{
    Task<List<PlaneTripEntity>> GetPlaneTrips();
    Task InsertPlaneTrip(PlaneTripCreationDto entity);
    Task Edit(Y entity, Guid id, int? PlaneId);

}
