using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO;
using EfCoreMigrations.DTO.CreationDto;

namespace EfCoreMigrations.Services.Interfaces
{
    public interface IPassengerService<T> : IBaseService<T>
    {
        Task<VipPassengerEntity> GetVipPassengerById(Guid id);
        Task<List<VipPassengerEntity>> GetVipPassengers();
        Task InsertVipPassenger(VipPassengerEntity entity);
    }
}
