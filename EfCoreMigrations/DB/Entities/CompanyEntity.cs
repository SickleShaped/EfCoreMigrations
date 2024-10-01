using EfCoreMigrations.DB.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities;

public class CompanyEntity:BaseEntity<Guid>
{
    public string Name { get; set; } = default!;
    public List<TripEntity> tripModels { get; set; } = new List<TripEntity>();
}
