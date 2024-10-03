using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreMigrations.Controllers;

[ApiController]
[Route("/")]
public class HomeController : Controller
{
    private readonly IEntityPoster _entityPoster;
    private readonly IEntityGetter _entityGetter;
    public HomeController(IEntityPoster entityPoster, IEntityGetter entityGetter)
    {
        _entityPoster = entityPoster;
        _entityGetter = entityGetter;
    }


    [HttpPost("InsertCompanyEntity")]
    public async Task InsertCompanyEntity(CompanyCreationDto entity)
    {
        await _entityPoster.InsertCompanyEntity(entity);
    }

    [HttpPost("InsertStateOwnedCompany")]
    public async Task InsertStateOwnedCompany(StateOwnedCompanyCreationDto entity)
    {
        await _entityPoster.InsertStateOwnedCompany(entity);
    }

    [HttpPost("InsertTripEntity")]
    public async Task InsertTripEntity(TripCreationDto entity)
    {
        await _entityPoster.InsertTripEntity(entity);
    }

    [HttpPost("InsertPlaneTripEntity")]
    public async Task InsertPlaneTripEntity(PlaneTripCreationDto entity)
    {
        await _entityPoster.InsertPlaneTripEntity(entity);
    }

    [HttpPost("InsertPassengerEntity")]
    public async Task InsertPassengerEntity(PassengerCreationDto entity)
    {
        await _entityPoster.InsertPassengerEntity(entity);
    }

    [HttpPost("InsertVipPassengerEntity")]
    public async Task InsertVipPassengerEntity(VipPassengerCreationDto entity)
    {
        await _entityPoster.InsertVipPassengerEntity(entity);
    }

    [HttpGet("GetCompanies")]
    public async Task<List<CompanyEntity>> GetCompanies()
    {
        return await _entityGetter.GetCompanies();
    }

    [HttpGet("GetStateOwnedCompanies")]
    public async Task<List<StateOwnedCompanyEntity>> GetStateOwnedCompanies()
    {
        return await _entityGetter.GetStateOwnedCompanies();
    }

    [HttpGet("GetPassengers")]
    public async Task<List<PassengerEntity>> GetPassengers()
    {
        return await _entityGetter.GetPassengers();
    }

    [HttpGet("GetVipPassengers")]
    public async Task<List<VipPassengerEntity>> GetVipPassengers()
    {
        return await _entityGetter.GetVipPassengers();
    }

    [HttpGet("GetTrips")]
    public async Task<List<TripEntity>> GetTrips()
    {
        return await _entityGetter.GetTrips();
    }

    [HttpGet("GetPlaneTrips")]
    public async Task<List<PlaneTripEntity>> GetPlaneTrips()
    {
        return await _entityGetter.GetPlaneTrips();
    }
}