using EfCoreMigrations.DB.Entities.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities;

[Table("companies")]
public class CompanyEntity : EntityBase
{
    [Column("name")]
    public string Name { get; set; } = default!;
    public List<TripEntity> Trips { get; set; } = new List<TripEntity>();
}
