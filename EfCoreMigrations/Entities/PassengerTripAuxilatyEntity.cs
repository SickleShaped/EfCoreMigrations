using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.Entities;

[Table("PassengerTrips")]
public class PassengerTripAuxilatyEntity
{
    [Key]
    public Guid Id { get; set; }
    public Guid TripId { get; set; }
    public Guid PassengerId { get; set; }

    [Required]
    public string? Place { get; set; }
    [Required]
    public PassengerEntity? Passenger { get; set; }
    [Required]
    public TripEntity? Trip { get; set; }
}
