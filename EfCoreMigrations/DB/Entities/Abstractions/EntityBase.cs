using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities.Abstractions;
public abstract class EntityBase : IEntity
{
    [Column("id")]
    public Guid Id { get; set; }
}
