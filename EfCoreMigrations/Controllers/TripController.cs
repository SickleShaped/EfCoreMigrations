using Microsoft.AspNetCore.Mvc;

namespace EfCoreMigrations.Controllers;

[ApiController]
[Route("/Trips")]
public class TripController:Controller
{
    private readonly ITripRepository _tripRepository;
    
    public TripController(TripRepository repository)
    {
        _tripRepository = repository;
    }
}
