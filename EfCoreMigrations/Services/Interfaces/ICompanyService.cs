using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;

namespace EfCoreMigrations.Services.Interfaces
{
    public interface ICompanyService<T>:IBaseService<T>
    {
        Task InsertStateOwnedCompany(StateOwnedCompanyCreationDto entity);

    }
}
