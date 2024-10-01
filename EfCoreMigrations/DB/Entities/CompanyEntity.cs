using EfCoreMigrations.DB.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities;

[Table("сompanies")]
[Index("Id")]
public class CompanyEntity:BaseEntity<int>
{

    [Required]
    public string Name { get; set; } = default!;

    public List<TripEntity> tripModels { get; set; } = new List<TripEntity>();
}
