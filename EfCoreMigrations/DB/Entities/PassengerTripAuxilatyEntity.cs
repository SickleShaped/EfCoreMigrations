using EfCoreMigrations.DB.Entities.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities;

public class PassengerTripAuxilatyEntity: BaseEntity<Guid>
{
    public Guid TripId { get; set; }
    public Guid PassengerId { get; set; }
    public string Place { get; set; } = default!;
    public PassengerEntity Passenger { get; set; } = default!;
    public TripEntity Trip { get; set; } = default!;
}
