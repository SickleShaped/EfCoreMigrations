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
[Route("/PlaneTrips")]
public class PlaneTripController:Controller
{
    private readonly IPlaneTripService _planeTripService;
    public PlaneTripController(IPlaneTripService planeTripService)
    {
        _planeTripService = planeTripService;
    }

    [HttpGet("GetAll")]
    public async Task<List<PlaneTripEntity>> GetAll(CancellationToken cancellationToken)
    {
        return await _planeTripService.GetAllAsync(cancellationToken);
    }

    [HttpGet("GetById")]
    public async Task<PlaneTripEntity> GetByIdAsync(Guid Id, CancellationToken cancellationToken)
    {
        return await _planeTripService.GetByIdAsync(Id, cancellationToken);
    }

    [HttpPost("Insert")]
    public async Task InsertAsync(PlaneTripCreationDto dto, CancellationToken cancellationToken)
    {
        await _planeTripService.InsertAsync(dto, cancellationToken);
    }

    [HttpPut("Edit")]
    public async Task UpdateAsync(PlaneTripEditDto dto, Guid Id, CancellationToken cancellationToken)
    {
        await _planeTripService.UpdateAsync(dto, Id, cancellationToken);
    }

    [HttpDelete("Delete")]
    public async Task DeleteByIdAsync(Guid Id, CancellationToken cancellationToken)
    {
        await _planeTripService.DeleteByIdAsync(Id, cancellationToken);
    }
}
