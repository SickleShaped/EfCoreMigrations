using EfCoreMigrations.DB.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities;

public class PassengerEntity: BaseEntity<Guid>
{
    public string Name { get; set; } = default!;
    public List<TripEntity> Trips { get; set; } = new List<TripEntity>();
    public List<PassengerTripAuxilatyEntity> PassengerTrips { get; set; } = new List<PassengerTripAuxilatyEntity>();
}
