using AutoMapper;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Repositories.Interfaces;
using EfCoreMigrations.Services;
using EfCoreMigrations.Services.Implementations;
using EfCoreMigrations.Services.Interfaces;
using System;

namespace EfCoreMigrations.Repositories.Implementations;

public class CompanyRepository<T,Y> : ICompanyRepository<T,Y> where T : CompanyEntity where Y : CompanyCreationDto
{
    private readonly ICompanyService<T> _companyService;
    private readonly IMapper _mapper;
    public CompanyRepository(CompanyService<T> companyService, IMapper mapper)
    {
        _companyService = companyService;
        _mapper = mapper;
    }

    public async Task<List<T>> GetAll()
    {
        return await _companyService.GetAll();
    }

    public async Task<T> GetById(Guid Id)
    {
        return await _companyService.GetById(Id);
    }

    public async Task<List<StateOwnedCompanyEntity>> GetStateOwnedCompanies()
    {
        return await _companyService.GetStateOwnedCompanies();
    }

    public async Task Insert(Y entity)
    {
        var company = _mapper.Map<T>(entity);
        await _companyService.Insert(company);
    }
    public async Task InsertStateOwnedCompany(StateOwnedCompanyCreationDto entity)
    {
        var company = _mapper.Map<StateOwnedCompanyEntity>(entity);
        await _companyService.InsertStateOwnedCompany(company);
    }
    public async Task Edit(Y entity, Guid id)
    {
        var company = await _companyService.GetById(id);
        if(entity.Name != null) {company.Name = entity.Name;}
        await _companyService.Save();

    }
    public async Task Edit(Y entity, Guid id, string? CompanyCountry = null)
    {
        var company = await _companyService.GetStateOwnedCompadyById(id);
        if(entity.Name !=null) {company.Name = entity.Name;}
        if(CompanyCountry !=null) { company.CompanyCountry = CompanyCountry;}
        await _companyService.Save();
    }

    public async Task Delete(Guid Id)
    {
        await _companyService.Delete(Id);
    }
}
