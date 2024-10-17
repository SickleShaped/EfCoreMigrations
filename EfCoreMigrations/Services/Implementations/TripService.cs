using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DB;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Repositories;
using EfCoreMigrations.Services.Interfaces;
using EfCoreMigrations.UnitsOfWork;
using Microsoft.EntityFrameworkCore;
using EfCoreMigrations.DTO.EditDto;

namespace EfCoreMigrations.Services.Implementations;

public class TripService : ITripService
{
    private readonly UnitOfWork _unitOfWork;
    private readonly IRepository<TripEntity> _repository;

    public TripService(IRepository<TripEntity> repository, ApiDbContext context)
    {
        _repository = repository;
        _unitOfWork = new UnitOfWork(context);
    }

    public async Task<List<TripEntity>> GetAllAsync(CancellationToken cancellationToken)
    {
        var list = _repository.GetAll();
        var result = await list.ToListAsync(cancellationToken);
        return result;
    }

    public async Task<TripEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _repository.GetByIdAsync(id, false, cancellationToken);
        return result;
    }

    public async Task InsertAsync(TripCreationDto dto, CancellationToken cancellationToken)
    {
        TripEntity entity = new TripEntity();
        entity.Id = new Guid();
        entity.CompanyId = dto.CompanyId;
        entity.TimeIn = dto.TimeIn;
        entity.TimeOut = dto.TimeOut;
        entity.TownFrom = dto.TownFrom;
        entity.TownTo = dto.TownTo;

        _repository.Insert(entity);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(TripEditDto dto, Guid id, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(id, true, cancellationToken);
        if (entity != null)
        {
            if(dto.CompanyId != null) entity.CompanyId = (Guid)dto.CompanyId;
            if(dto.TimeIn != null) entity.TimeIn = (DateTime)dto.TimeIn;
            if(dto.TimeOut!= null) entity.TimeOut = (DateTime)dto.TimeOut;
            if(dto.TownFrom != null) entity.TownFrom = dto.TownFrom;
            if(dto.TownTo != null) entity.TownTo = dto.TownTo;
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }

    public async Task DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        await _repository.ExecuteDeleteAsync(x => x.Id == id, cancellationToken);
        //тут можно экспепшн кинуть
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
