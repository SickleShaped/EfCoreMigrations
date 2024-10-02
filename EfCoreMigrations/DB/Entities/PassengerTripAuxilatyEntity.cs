using EfCoreMigrations.DB.Entities.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities;

[Table ("passengertrips")]
public class PassengerTripAuxilatyEntity: BaseEntity<Guid>
{
    [Column("trip_id")]
    public Guid TripId { get; set; }
    [Column("passenger_id")]
    public Guid PassengerId { get; set; }
    [Column("place")]
    public string Place { get; set; } = default!;
    public PassengerEntity Passenger { get; set; } = default!;
    public TripEntity Trip { get; set; } = default!;
}
