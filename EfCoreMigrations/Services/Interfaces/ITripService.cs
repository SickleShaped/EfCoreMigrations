using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.DTO;

namespace EfCoreMigrations.Services.Interfaces
{
    public interface ITripService<T> : IBaseService<T>
    {
        Task<List<PlaneTripEntity>> GetPlaneTrips();
        Task<PlaneTripEntity> GetPlaneTipById(Guid id);
        Task InsertPlaneTrip(PlaneTripEntity entity);
    }
}
