using EfCoreMigrations.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreMigrations.Controllers;

[ApiController]
[Route("/Companies")]
public class CompanyCorntroller:Controller
{
    private readonly ICompanyRepository _tripRepository;

    public CompanyCorntroller(CompanyRepository repository)
    {
        _tripRepository = repository;
    }
}
