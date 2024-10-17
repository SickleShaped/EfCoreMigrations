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
[Route("/StateOwnedCompanies")]
public class StateOwnedCompanyController:Controller
{
    private readonly IStateOwnedCompanyService _stateOwnedCompanyService;
    public StateOwnedCompanyController(IStateOwnedCompanyService stateOwnedCompanyService)
    {
        _stateOwnedCompanyService = stateOwnedCompanyService;
    }

    [HttpGet("GetAll")]
    public async Task<List<StateOwnedCompanyEntity>> GetAll(CancellationToken cancellationToken)
    {
        return await _stateOwnedCompanyService.GetAllAsync(cancellationToken);
    }

    [HttpGet("GetById")]
    public async Task<StateOwnedCompanyEntity> GetByIdAsync(Guid Id, CancellationToken cancellationToken)
    {
        return await _stateOwnedCompanyService.GetByIdAsync(Id, cancellationToken);
    }

    [HttpPost("Insert")]
    public async Task InsertAsync(StateOwnedCompanyCreationDto dto, CancellationToken cancellationToken)
    {
        await _stateOwnedCompanyService.InsertAsync(dto, cancellationToken);
    }

    [HttpPut("Edit")]
    public async Task UpdateAsync(StateOwnedCompanyEditDto dto, Guid Id, CancellationToken cancellationToken)
    {
        await _stateOwnedCompanyService.UpdateAsync(dto, Id, cancellationToken);
    }

    [HttpDelete("Delete")]
    public async Task DeleteByIdAsync(Guid Id, CancellationToken cancellationToken)
    {
        await _stateOwnedCompanyService.DeleteByIdAsync(Id, cancellationToken);
    }
}
