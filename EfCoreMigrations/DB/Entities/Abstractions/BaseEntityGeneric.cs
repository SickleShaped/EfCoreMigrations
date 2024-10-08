using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities.Abstractions;
public abstract class BaseEntityGeneric<T>:BaseEntity
{
    [Column("id")]
    public T Id { get; set; }
}
