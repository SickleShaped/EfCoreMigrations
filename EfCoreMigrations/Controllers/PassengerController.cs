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
[Route("/Passengers")]
public class PassengerController:Controller
{
    private readonly IPassengerService _passengerService;
    public PassengerController(IPassengerService passengerService)
    {
        _passengerService = passengerService;
    }

    [HttpGet("GetAll")]
    public async Task<List<PassengerEntity>> GetAll(CancellationToken cancellationToken)
    {
        return await _passengerService.GetAllAsync(cancellationToken);
    }

    [HttpGet("GetById")]
    public async Task<PassengerEntity> GetByIdAsync(Guid Id, CancellationToken cancellationToken)
    {
        return await _passengerService.GetByIdAsync(Id, cancellationToken);
    }

    [HttpPost("Insert")]
    public async Task InsertAsync(PassengerCreationDto dto, CancellationToken cancellationToken)
    {
        await _passengerService.InsertAsync(dto, cancellationToken);
    }

    [HttpPut("Edit")]
    public async Task UpdateAsync(PassengerEditDto dto, Guid Id, CancellationToken cancellationToken)
    {
        await _passengerService.UpdateAsync(dto, Id, cancellationToken);
    }

    [HttpDelete("Delete")]
    public async Task DeleteByIdAsync(Guid Id, CancellationToken cancellationToken)
    {
        await _passengerService.DeleteByIdAsync(Id, cancellationToken);
    }
}
