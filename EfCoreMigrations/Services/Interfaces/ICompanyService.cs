using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;

namespace EfCoreMigrations.Services.Interfaces
{
    public interface ICompanyService<T>:IBaseService<T>
    {
        Task<StateOwnedCompanyEntity> GetStateOwnedCompadyById(Guid Id);
        Task<List<StateOwnedCompanyEntity>> GetStateOwnedCompanies();
        Task InsertStateOwnedCompany(StateOwnedCompanyEntity entity);
    }
}
