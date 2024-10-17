using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.DTO.EditDto;
using EfCoreMigrations.Services.Interfaces;
using EfCoreMigrations.UnitsOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.ComponentModel;

namespace EfCoreMigrations.Controllers;

[ApiController]
[Route("/Trips")]
public class TripsController:Controller
{
    private readonly ITripService _tripService;
    public TripsController(ITripService tripService)
    {
        _tripService = tripService;
    }

    [HttpGet("GetAll")]
    public async Task<List<TripEntity>> GetAll(CancellationToken cancellationToken)
    {
        return await _tripService.GetAllAsync(cancellationToken);
    }

    [HttpGet("GetById")]
    public async Task<TripEntity> GetByIdAsync(Guid Id, CancellationToken cancellationToken)
    {
        return await _tripService.GetByIdAsync(Id, cancellationToken);
    }

    [HttpPost("Insert")]
    public async Task InsertAsync(TripCreationDto dto, CancellationToken cancellationToken)
    {
        await _tripService.InsertAsync(dto, cancellationToken);
    }

    [HttpPut("Edit")]
    public async Task UpdateAsync(TripEditDto dto, Guid Id, CancellationToken cancellationToken)
    {
        await _tripService.UpdateAsync(dto, Id, cancellationToken);
    }

    [HttpDelete("Delete")]
    public async Task DeleteByIdAsync(Guid Id, CancellationToken cancellationToken)
    {
        await _tripService.DeleteByIdAsync(Id, cancellationToken);
    }
}
