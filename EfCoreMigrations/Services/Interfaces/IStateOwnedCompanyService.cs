using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.DTO.EditDto;

namespace EfCoreMigrations.Services.Interfaces
{
    public interface IStateOwnedCompanyService : IServiceBase<StateOwnedCompanyEntity, StateOwnedCompanyCreationDto, StateOwnedCompanyEditDto>
    {
        
    }
}
