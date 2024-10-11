using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.DTO.EditDto;

namespace EfCoreMigrations.Services.Interfaces
{
    public interface IVipPassengerService : IServiceBase<VipPassengerEntity, VipPassengerCreationDto, VipPassengerEditDto>
    {
    }
}
