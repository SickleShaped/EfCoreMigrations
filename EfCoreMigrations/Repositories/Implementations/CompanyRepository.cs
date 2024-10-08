using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Repositories.Interfaces;
using EfCoreMigrations.Services.Implementations;
using EfCoreMigrations.Services.Interfaces;

namespace EfCoreMigrations.Repositories.Implementations;

public class CompanyRepository<T,Y> : ICompanyRepository<T,Y> where T : CompanyEntity where Y : CompanyCreationDto
{
    private readonly ICompanyService<T> _companyService;
    public CompanyRepository(CompanyService<T> companyService)
    {
        _companyService = companyService;
    }

    public async Task<List<T>> GetAll()
    {
        return await _companyService.GetAll();
    }

    public async Task<T> GetById(Guid Id)
    {

    }

    public async Task<List<StateOwnedCompanyEntity>> GetStateOwnedCompanies()
    {

    }

    public async Task Insert(Y entity)
    {

    }
    public async Task InsertStateOwnedCompany(StateOwnedCompanyCreationDto entity)
    {

    }
    public async Task Edit(Y entity)
    {

    }
    public async Task Edit(Y entity, string CompanyCountry)
    {

    }

    public async Task Delete(Guid Id)
    {
        
    }
}
