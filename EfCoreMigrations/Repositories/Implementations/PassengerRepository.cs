using AutoMapper;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Repositories.Interfaces;
using EfCoreMigrations.Services.Implementations;
using EfCoreMigrations.Services.Interfaces;

namespace EfCoreMigrations.Repositories.Implementations;

public class PassengerRepository<T, Y> : IPassengerRepository<T, Y> where T : PassengerEntity where Y : PassengerCreationDto
{
    private readonly IPassengerService<T> _passengerService;
    private readonly IMapper _mapper;
    public PassengerRepository(PassengerService<T> passengerService, IMapper mapper)
    {
        _passengerService = passengerService;
        _mapper = mapper;
    }

    public async Task<List<T>> GetAll()
    {
        return await _passengerService.GetAll();
    }

    public async Task<T> GetById(Guid Id)
    {
        return await _passengerService.GetById(Id);
    }

    public async Task<List<VipPassengerEntity>> GetVipPassengers()
    {
        return await _passengerService.GetVipPassengers();
    }

    public async Task Insert(Y entity)
    {
        var passenger = _mapper.Map<T>(entity);
        await _passengerService.Insert(passenger);
    }

    public async Task InsertVipPassenger(VipPassengerCreationDto entity)
    {
        var passenger = _mapper.Map<VipPassengerEntity>(entity);
        await _passengerService.InsertVipPassenger(passenger);
    }

    public async Task Edit(Y entity, Guid Id, VipStatus? vipStatus)
    {
        var passenger = await _passengerService.GetVipPassengerById(Id);
        if (entity.Name != null) { passenger.Name = entity.Name; }
        if (vipStatus != null) { passenger.VipStatus = vipStatus; }
        await _passengerService.Save();
    }

    public async Task Edit(Y entity, Guid id)
    {
        var passenger = await _passengerService.GetById(id);
        if (entity.Name != null) { passenger.Name = entity.Name; }
        await _passengerService.Save();
    }

    public async Task Delete(Guid id)
    {
        await _passengerService.Delete(id);
    }
}
