using EfCoreMigrations.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Repositories
{
    public interface ITripRepository
    {
        Task<List<TripEntity>> GetAll();
        Task<TripEntity> GetById(Guid Id);
        Task<List<PlaneTripEntity>> GetPlaneTrips();
        Task InsertTrip(TripEntity trip);
        Task InsertPlaneTrip(PlaneTripEntity planeTrip);
        Task UpdateTrip(TripEntity trip, Guid id, int? Plane = null);
        Task DeleteTrip(Guid id);

    }
}
