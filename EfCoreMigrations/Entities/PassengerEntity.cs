using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.Entities;

[Table("Passengers")]
[Index("Id")]
public class PassengerEntity
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public List<TripEntity> Trips { get; set; } = new List<TripEntity>();
    public List<PassengerTripAuxilatyEntity> PassengerTrips { get; set; } = new List<PassengerTripAuxilatyEntity>();
}
