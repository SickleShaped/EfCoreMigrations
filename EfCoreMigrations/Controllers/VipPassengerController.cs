using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.DTO.EditDto;
using EfCoreMigrations.Services.Implementations;
using EfCoreMigrations.Services.Interfaces;
using EfCoreMigrations.UnitsOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.ComponentModel;

namespace EfCoreMigrations.Controllers;

[ApiController]
[Route("/VipPassengers")]
public class VipPassengerCorntroller:Controller
{
    private readonly IVipPassengerService _vipPassengerService;
    public VipPassengerCorntroller(IVipPassengerService vipPassengerService)
    {
        _vipPassengerService = vipPassengerService;
    }

    [HttpGet("GetAll")]
    public async Task<List<VipPassengerEntity>> GetAll(CancellationToken cancellationToken)
    {
        return await _vipPassengerService.GetAllAsync(cancellationToken);
    }

    [HttpGet("GetById")]
    public async Task<VipPassengerEntity> GetByIdAsync(Guid Id, CancellationToken cancellationToken)
    {
        return await _vipPassengerService.GetByIdAsync(Id, cancellationToken);
    }

    [HttpPost("Insert")]
    public async Task InsertAsync(VipPassengerCreationDto dto, CancellationToken cancellationToken)
    {
        await _vipPassengerService.InsertAsync(dto, cancellationToken);
    }

    [HttpPut("Edit")]
    public async Task UpdateAsync(VipPassengerEditDto dto, Guid Id, CancellationToken cancellationToken)
    {
        await _vipPassengerService.UpdateAsync(dto, Id, cancellationToken);
    }

    [HttpDelete("Delete")]
    public async Task DeleteByIdAsync(Guid Id, CancellationToken cancellationToken)
    {
        await _vipPassengerService.DeleteByIdAsync(Id, cancellationToken);
    }
}
