using AutoMapper;
using EfCoreMigrations.DB;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Repositories.Implementations;
using EfCoreMigrations.Services.Implementations;

namespace EfCoreMigrations;

public class CompanyUnitOfWork<T, Y> where T : CompanyEntity where Y : CompanyCreationDto
{
    private readonly CompanyService<T> _companyService;
    private readonly IMapper _mapper;
    private CompanyRepository<T, Y> _companyRepository;

    public CompanyUnitOfWork(ApiDbContext context, IMapper mapper, CompanyService<T> companyService)
    {
        _companyService = companyService;
        _mapper = mapper;
    }

    public CompanyRepository<T, Y> Companies
    {
        get
        {
            if (_companyRepository == null)
                _companyRepository = new CompanyRepository<T, Y>(_companyService, _mapper);
            return _companyRepository;
        }
    }

}
