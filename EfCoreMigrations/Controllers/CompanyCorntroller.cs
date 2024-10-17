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
[Route("/Companies")]
public class CompanyController:Controller
{
    private readonly ICompanyService _companyService;
    public CompanyController(ICompanyService companyService)
    {
        _companyService = companyService;
    }

    [HttpGet("GetAll")]
    public async Task<List<CompanyEntity>> GetAll(CancellationToken cancellationToken)
    {

        return await _companyService.GetAllAsync(cancellationToken);
        
    }

    [HttpGet("GetById")]
    public async Task<CompanyEntity> GetByIdAsync(Guid Id, CancellationToken cancellationToken)
    {
        return await _companyService.GetByIdAsync(Id, cancellationToken);
    }

    [HttpPost("Insert")]
    public async Task InsertAsync(CompanyCreationDto dto, CancellationToken cancellationToken)
    {
        await _companyService.InsertAsync(dto, cancellationToken);
    }

    [HttpPut("Edit")]
    public async Task UpdateAsync(CompanyEditDto dto, Guid Id, CancellationToken cancellationToken)
    {
        await _companyService.UpdateAsync(dto, Id, cancellationToken);
    }

    [HttpDelete("Delete")]
    public async Task DeleteByIdAsync(Guid Id, CancellationToken cancellationToken)
    {
        await _companyService.DeleteByIdAsync(Id, cancellationToken);
    }
}
