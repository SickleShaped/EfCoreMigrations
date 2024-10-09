using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DB.Entities.Abstractions;
using EfCoreMigrations.DTO;
using EfCoreMigrations.DTO.CreationDto;

namespace EfCoreMigrations.Repositories.Interfaces;

public interface IPassengerRepository<T, Y> : IBaseRepository<T, Y> where T : BaseEntity where Y : BaseCreationDto
{
    Task<List<VipPassengerEntity>> GetVipPassengers();
    Task InsertVipPassenger(VipPassengerCreationDto entity);
    Task Edit(Y entity, Guid Id, VipStatus? vipStatus);
}
