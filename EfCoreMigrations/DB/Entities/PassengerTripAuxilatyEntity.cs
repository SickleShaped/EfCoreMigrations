using EfCoreMigrations.DB.Entities.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities;

[Table ("passengerTrips")]
public class PassengerTripAuxilatyEntity
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
