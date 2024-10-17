using EfCoreMigrations.DB;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.DTO.EditDto;
using EfCoreMigrations.Repositories;
using EfCoreMigrations.Services.Interfaces;
using EfCoreMigrations.UnitsOfWork;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Services.Implementations;

public class CompanyService : ICompanyService
{
    private readonly UnitOfWork _unitOfWork;
    private readonly IRepository<CompanyEntity> _repository;

    public CompanyService(IRepository<CompanyEntity> repository, ApiDbContext context)
    {
        _repository = repository;
        _unitOfWork = new UnitOfWork(context);
    }

    public async Task<List<CompanyEntity>> GetAllAsync(CancellationToken cancellationToken)
    {
        var list = _repository.GetAll();
        var result = await list.ToListAsync(cancellationToken);
        return result;
    }

    public async Task<CompanyEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _repository.GetByIdAsync(id, false, cancellationToken);
        return result;
    }

    public async Task InsertAsync(CompanyCreationDto dto, CancellationToken cancellationToken)
    {
        CompanyEntity entity = new CompanyEntity();
        entity.Id = new Guid();
        entity.Name = dto.Name;

        _repository.Insert(entity);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(CompanyEditDto dto, Guid id, CancellationToken cancellationToken)
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
