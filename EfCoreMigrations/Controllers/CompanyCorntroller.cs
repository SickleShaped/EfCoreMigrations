using EfCoreMigrations.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreMigrations.Controllers;

[ApiController]
[Route("/Companies")]
public class CompanyCorntroller:Controller
{
    private readonly ICompanyRepository<Guid> _tripRepository;

    public CompanyCorntroller(CompanyRepository<Guid> repository)
    {
        _tripRepository = repository;
    }
}
