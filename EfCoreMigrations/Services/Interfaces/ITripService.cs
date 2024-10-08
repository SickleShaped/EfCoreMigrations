using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.DTO;

namespace EfCoreMigrations.Services.Interfaces
{
    public interface ITripService<T> : IBaseService<T>
    {
        Task InsertPlaneTrip(PlaneTripEntity entity);
    }
}
