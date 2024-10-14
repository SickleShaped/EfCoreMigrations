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
    public async Task<List<PassengerEntity>> GetAll()
    {
        return await _passengerService.GetAllAsync();
    }

    [HttpGet("GetById")]
    public async Task<PassengerEntity> GetByIdAsync(Guid Id)
    {
        return await _passengerService.GetByIdAsync(Id);
    }

    [HttpPost("Insert")]
    public async Task InsertAsync(PassengerCreationDto dto)
    {
        await _passengerService.InsertAsync(dto);
    }

    [HttpPut("Edit")]
    public async Task UpdateAsync(PassengerEditDto dto, Guid Id)
    {
        await _passengerService.UpdateAsync(dto, Id);
    }

    [HttpDelete("Delete")]
    public async Task DeleteByIdAsync(Guid Id)
    {
        await _passengerService.DeleteByIdAsync(Id);
    }
}
