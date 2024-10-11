using EfCoreMigrations.DB;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.DTO.EditDto;
using EfCoreMigrations.Repositories;
using EfCoreMigrations.Services.Interfaces;
using EfCoreMigrations.UnitsOfWork;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Services.Implementations;

public class PassengerService : IPassengerService
{
    private readonly UnitOfWork _unitOfWork;
    private readonly IRepository<PassengerEntity> _repository;

    public PassengerService(IRepository<PassengerEntity> repository, ApiDbContext context)
    {
        _repository = repository;
        _unitOfWork = new UnitOfWork(context);
    }

    public async Task<List<PassengerEntity>> GetAllAsync()
    {
        var list = _repository.GetAll();
        var result = await list.ToListAsync();
        return result;
    }

    public async Task<PassengerEntity> GetByIdAsync(Guid id)
    {
        var result = await _repository.GetByIdAsync(id, false, default);
        return result;
    }

    public async Task InsertAsync(PassengerCreationDto dto)
    {
        PassengerEntity entity = new PassengerEntity();
        entity.Id = new Guid();
        entity.Name = dto.Name;

        _repository.Insert(entity);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task UpdateAsync(PassengerEditDto dto, Guid id)
    {
        var entity = await _repository.GetByIdAsync(id, true, default);
        if (entity != null)
        {
            if (dto.Name != null) entity.Name = dto.Name;
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
