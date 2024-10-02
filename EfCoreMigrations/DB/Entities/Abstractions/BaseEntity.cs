using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities.Abstractions;
public abstract class BaseEntity<T>
{
    [Column("id")]
    public T Id { get; set; }
}
