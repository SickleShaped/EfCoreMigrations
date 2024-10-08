using Microsoft.AspNetCore.Mvc;

namespace EfCoreMigrations.Controllers;

[ApiController]
[Route("/Passengers")]
public class PassengerController : Controller
{
    private readonly IPassengerRepository _passengersRepository;

    public PassengerController(PassengerRepository repository)
    {
        _passengersRepository = repository;
    }
}
