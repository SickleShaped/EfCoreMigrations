using EfCoreMigrations.DB;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.DTO.EditDto;
using EfCoreMigrations.Repositories;
using EfCoreMigrations.Services.Interfaces;
using EfCoreMigrations.UnitsOfWork;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Services.Implementations;

public class StateOwnedCompanyService : IStateOwnedCompanyService
{
    private readonly UnitOfWork _unitOfWork;
    private readonly IRepository<StateOwnedCompanyEntity> _repository;

    public StateOwnedCompanyService(IRepository<StateOwnedCompanyEntity> repository, ApiDbContext context)
    {
        _repository = repository;
        _unitOfWork = new UnitOfWork(context);
    }

    public async Task<List<StateOwnedCompanyEntity>> GetAllAsync(CancellationToken cancellationToken)
    {
        var list = _repository.GetAll();
        var result = await list.ToListAsync(cancellationToken);
        return result;
    }

    public async Task<StateOwnedCompanyEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _repository.GetByIdAsync(id, false, cancellationToken);
        return result;
    }

    public async Task InsertAsync(StateOwnedCompanyCreationDto dto, CancellationToken cancellationToken)
    {
        StateOwnedCompanyEntity entity = new StateOwnedCompanyEntity();
        entity.Id = new Guid();
        entity.Name = dto.Name;
        entity.CompanyCountry = dto.CompanyCountry;

        _repository.Insert(entity);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(StateOwnedCompanyEditDto dto, Guid id, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(id, true, cancellationToken);
        if (entity != null)
        {
            if(dto.Name != null) entity.Name = dto.Name;
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
