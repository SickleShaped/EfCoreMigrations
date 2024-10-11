using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DB;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Repositories;
using EfCoreMigrations.Services.Interfaces;
using EfCoreMigrations.UnitsOfWork;
using Microsoft.EntityFrameworkCore;
using EfCoreMigrations.DTO.EditDto;

namespace EfCoreMigrations.Services.Implementations;

public class PlaneTripService : IPlaneTripService
{
    private readonly UnitOfWork _unitOfWork;
    private readonly IRepository<PlaneTripEntity> _repository;

    public PlaneTripService(IRepository<PlaneTripEntity> repository, ApiDbContext context)
    {
        _repository = repository;
        _unitOfWork = new UnitOfWork(context);
    }

    public async Task<List<PlaneTripEntity>> GetAllAsync()
    {
        var list = _repository.GetAll();
        var result = await list.ToListAsync();
        return result;
    }

    public async Task<PlaneTripEntity> GetByIdAsync(Guid id)
    {
        var result = await _repository.GetByIdAsync(id, false, default);
        return result;
    }

    public async Task InsertAsync(PlaneTripCreationDto dto)
    {
        PlaneTripEntity entity = new PlaneTripEntity();
        entity.Id = new Guid();
        entity.CompanyId = dto.CompanyId;
        entity.TimeIn = dto.TimeIn;
        entity.TimeOut = dto.TimeOut;
        entity.TownFrom = dto.TownFrom;
        entity.TownTo = dto.TownTo;
        entity.PlaneId = dto.PlaneId;

        _repository.Insert(entity);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task UpdateAsync(PlaneTripEditDto dto, Guid id)
    {
        var entity = await _repository.GetByIdAsync(id, true, default);
        if (entity != null)
        {
            if(dto.CompanyId != null) entity.CompanyId = (Guid)dto.CompanyId;
            if(dto.TimeIn != null) entity.TimeIn = (DateTime)dto.TimeIn;
            if(dto.TimeOut!= null) entity.TimeOut = (DateTime)dto.TimeOut;
            if(dto.TownFrom != null) entity.TownFrom = dto.TownFrom;
            if(dto.TownTo != null) entity.TownTo = dto.TownTo;
            if (dto.PlaneId != null) entity.PlaneId = (int)dto.PlaneId;
            await _unitOfWork.SaveChangesAsync();
        }
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        await _repository.ExecuteDeleteAsync(x => x.Id == id, default);
        //тут можно экспепшн кинуть
        await _unitOfWork.SaveChangesAsync();
    }
}
