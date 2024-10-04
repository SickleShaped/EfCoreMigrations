using EfCoreMigrations.DB.Entities.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities;

[Table("trips")]
public class TripEntity : BaseEntity<Guid>
{
    [Column("company_id")]
    public Guid CompanyId { get; set; }
    [Column("plane")]
    public string Plane { get; set; } = default!;
    [Column("town_from")]
    public string TownFrom { get; set; } = default!;
    [Column("town_to")]
    public string TownTo { get; set; } = default!;
    [Column("time_in")]
    public DateTime TimeIn { get; set; }
    [Column("time_out")]
    public DateTime TimeOut { get; set; }
    public List<PassengerEntity> Passengers { get; set; } = new List<PassengerEntity>();
    public List<PassengerTripAuxilatyEntity> PassengerTrips { get; set; } = new List<PassengerTripAuxilatyEntity>();
    public CompanyEntity Company { get; set; } = default!;
}
