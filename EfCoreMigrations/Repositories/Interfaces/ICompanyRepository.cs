using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DB.Entities.Abstractions;
using EfCoreMigrations.DTO.CreationDto;

namespace EfCoreMigrations.Repositories.Interfaces;

public interface ICompanyRepository<T, Y> : IBaseRepository<T, Y> where T:BaseEntity where Y : BaseCreationDto
{

    Task<List<StateOwnedCompanyEntity>> GetStateOwnedCompanies();
    Task InsertStateOwnedCompany(StateOwnedCompanyCreationDto entity);
    Task Edit(Y entity, string CompanyCountry);
}
