﻿using EfCoreMigrations.DB;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.DTO.EditDto;
using EfCoreMigrations.Repositories;
using EfCoreMigrations.Services.Interfaces;
using EfCoreMigrations.UnitsOfWork;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Services.Implementations;

public class VipPassengerService : IVipPassengerService
{
    private readonly UnitOfWork _unitOfWork;
    private readonly IRepository<VipPassengerEntity> _repository;

    public VipPassengerService(IRepository<VipPassengerEntity> repository, ApiDbContext context)
    {
        _repository = repository;
        _unitOfWork = new UnitOfWork(context);
    }

    public async Task<List<VipPassengerEntity>> GetAllAsync(CancellationToken cancellationToken)
    {
        var list = _repository.GetAll();
        var result = await list.ToListAsync(cancellationToken);
        return result;
    }

    public async Task<VipPassengerEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _repository.GetByIdAsync(id, false, cancellationToken);
        return result;
    }

    public async Task InsertAsync(VipPassengerCreationDto dto, CancellationToken cancellationToken)
    {
        VipPassengerEntity entity = new VipPassengerEntity();
        entity.Id = new Guid();
        entity.Name = dto.Name;
        entity.VipStatus = dto.VipStatus;

        _repository.Insert(entity);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(VipPassengerEditDto dto, Guid id, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(id, true, cancellationToken);
        if (entity != null)
        {
            if (dto.Name != null) entity.Name = dto.Name;
            if (dto.VipStatus != null) entity.VipStatus = dto.VipStatus;
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }

    public async Task DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        await _repository.ExecuteDeleteAsync(x => x.Id == id, default);
        //тут можно экспепшн кинуть
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
