using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO;
using EfCoreMigrations.DTO.CreationDto;

namespace EfCoreMigrations.Repositories.Interfaces;

public interface IPassengerRepository<T> : IBaseRepository<PassengerEntity, PassengerCreationDto>
{
    Task<List<VipPassengerEntity>> GetVipPassengers();
    Task InsertVipPassenger(VipPassengerCreationDto entity);
    Task Edit(PassengerCreationDto dto, VipStatus vipStatus);
}
