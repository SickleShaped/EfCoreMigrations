using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Services.Interfaces;
using EfCoreMigrations.UnitsOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.ComponentModel;

namespace EfCoreMigrations.Controllers;

[ApiController]
[Route("/Companies")]
public class CompanyCorntroller:Controller
{
    private readonly ICompanyService _companyService;
    public CompanyCorntroller(ICompanyService companyService)
    {
        _companyService = companyService;
    }

    [HttpGet("GetAll")]
    public async Task GetAll()
    {
        await _companyService.GetAllAsync();

        _companyService.GetByIdAsync;
        _companyService.DeleteByIdAsync;
        _companyService.InsertAsync;
        _companyService.UpdateAsync;
    }

    

}
