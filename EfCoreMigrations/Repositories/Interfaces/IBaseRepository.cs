using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DB.Entities.Abstractions;
using EfCoreMigrations.DTO.CreationDto;
using System.ComponentModel;

namespace EfCoreMigrations.Repositories.Interfaces;

public interface IBaseRepository<T, Y> where T : BaseEntity where Y : BaseCreationDto
{
    Task<List<T>> GetAll();
    Task<T> GetById(Guid Id);
    Task Insert(Y entity);
    Task Edit(Y entity);
    Task Delete(Guid id);

}
