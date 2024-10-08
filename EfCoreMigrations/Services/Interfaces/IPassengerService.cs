using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO;
using EfCoreMigrations.DTO.CreationDto;

namespace EfCoreMigrations.Services.Interfaces
{
    public interface IPassengerService<T> : IBaseService<T>
    {
        Task InsertVipPassenger(VipPassengerCreationDto entity);
    }
}
