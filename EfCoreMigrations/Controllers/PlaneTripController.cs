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
    public async Task<List<PlaneTripEntity>> GetAll()
    {
        return await _planeTripService.GetAllAsync();
    }

    [HttpGet("GetById")]
    public async Task<PlaneTripEntity> GetByIdAsync(Guid Id)
    {
        return await _planeTripService.GetByIdAsync(Id);
    }

    [HttpPost("Insert")]
    public async Task InsertAsync(PlaneTripCreationDto dto)
    {
        await _planeTripService.InsertAsync(dto);
    }

    [HttpPut("Edit")]
    public async Task UpdateAsync(PlaneTripEditDto dto, Guid Id)
    {
        await _planeTripService.UpdateAsync(dto, Id);
    }

    [HttpDelete("Delete")]
    public async Task DeleteByIdAsync(Guid Id)
    {
        await _planeTripService.DeleteByIdAsync(Id);
    }
}
