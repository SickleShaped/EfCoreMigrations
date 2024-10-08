namespace EfCoreMigrations.Services.Interfaces;

public interface IBaseService<T>
{
    Task<List<T>> GetAll();
    Task<T> GetById(Guid Id);
    Task Insert(T entity);
    Task Delete(Guid id);
}
