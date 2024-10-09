using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Repositories.Interfaces;
using EfCoreMigrations.UnitsOfWork;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreMigrations.Controllers;

[ApiController]
[Route("/Companies")]
public class CompanyCorntroller:Controller
{
    private PassengerUnitOfWork<PassengerEntity, PassengerCreationDto> _UoW;

    //private readonly ICompanyRepository<Guid> _tripRepository;

    public CompanyCorntroller(PassengerUnitOfWork<PassengerEntity, PassengerCreationDto> UoW)
    {
        _UoW = UoW;
    }
}
