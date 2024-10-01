namespace EfCoreMigrations.DB.Entities.Abstractions
{
    public abstract class BaseEntity<T>
    {
        T Id { get; set; }
    }
}
