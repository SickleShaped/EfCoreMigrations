using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.Entities;

[Table("Trips")]
[Index("Id")]
public class TripEntity
{
    [Key]
    public Guid Id { get; set; }
    public Guid CompanyId { get; set; }

    [Required]
    public string? Plane { get; set; }

    [Required]
    public string? TownFrom { get; set; }

    [Required]
    public string? TownTo { get; set; }
    public DateTime TimeIn { get; set; }
    public DateTime TimeOut { get; set; }

    [Required]
    public List<PassengerEntity> Passengers { get; set; } = new List<PassengerEntity>();
    [Required]
    public List<PassengerTripAuxilatyEntity> PassengerTrips { get; set; } = new List<PassengerTripAuxilatyEntity>();
    [Required]
    public CompanyEntity? Company { get; set; } 
}
