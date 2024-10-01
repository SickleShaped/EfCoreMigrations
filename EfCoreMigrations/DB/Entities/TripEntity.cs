using EfCoreMigrations.DB.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities;

public class TripEntity : BaseEntity<Guid>
{
    public Guid CompanyId { get; set; }
    public string Plane { get; set; } = default!;
    public string TownFrom { get; set; } = default!;
    public string TownTo { get; set; } = default!;

    public int RandomField {  get; set; }

    public DateTime TimeIn { get; set; }
    public DateTime TimeOut { get; set; }
    public List<PassengerEntity> Passengers { get; set; } = new List<PassengerEntity>();
    public List<PassengerTripAuxilatyEntity> PassengerTrips { get; set; } = new List<PassengerTripAuxilatyEntity>();
    public CompanyEntity Company { get; set; } = default!;
}
