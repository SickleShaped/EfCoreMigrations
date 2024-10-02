using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities
{
    public class PlaneTripEntity:TripEntity
    {
        public int PlaneId { get; set; }
    }
}
