using EfCoreMigrations.DB.Entities.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities;

[Table("PassengerTrips")]
public class PassengerTripAuxilatyEntity: BaseEntity<Guid>
{
    public Guid TripId { get; set; }
    public Guid PassengerId { get; set; }

    [Required]
    public string? Place { get; set; }
    [Required]
    public PassengerEntity? Passenger { get; set; }
    [Required]
    public TripEntity? Trip { get; set; }
}
