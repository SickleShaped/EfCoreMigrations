using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.Entities;

[Table("Companies")]
[Index ("Id")]
public class CompanyEntity
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public List<TripEntity> tripModels { get; set; } = new List<TripEntity> ();
}
