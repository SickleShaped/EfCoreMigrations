using AutoMapper;
using EfCoreMigrations.DB;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Repositories.Interfaces;
using EfCoreMigrations.Services.Implementations;
using EfCoreMigrations.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.Repositories.Implementations;

public class TripRepository<T, Y> : ITripRepository<T, Y> where T : TripEntity where Y : TripCreationDto
{
    private readonly ITripService<T> _tripService;
    private readonly IMapper _mapper;
    public TripRepository(TripService<T> tripService, IMapper mapper)
    {
        _tripService = tripService;
        _mapper = mapper;
    }
    public async Task<List<T>> GetAll()
    {
        return await _tripService.GetAll();
    }

    public async Task<T> GetById(Guid Id)
    {
        return await _tripService.GetById(Id);
    }

    public Task<List<PlaneTripEntity>> GetPlaneTrips()
    {
        return _tripService.GetPlaneTrips();
    }

    public async Task Insert(Y entity)
    {
        var trip = _mapper.Map<T>(entity);
        await _tripService.Insert(trip);
    }

    public async Task InsertPlaneTrip(PlaneTripCreationDto entity)
    {
        var trip = _mapper.Map<PlaneTripEntity>(entity);
        await _tripService.InsertPlaneTrip(trip);
    }
    public async Task Edit(Y entity, Guid id)
    {
        var trip = await _tripService.GetById(id);
        if (entity.TimeIn != null) { trip.TimeIn = (DateTime)entity.TimeIn; }
        if (entity.TimeOut != null) { trip.TimeOut = (DateTime)entity.TimeOut; }
        if (entity.Plane != null) { trip.Plane = entity.Plane; }
        if (entity.TownFrom != null) { trip.TownFrom = entity.TownFrom; }
        if (entity.TownTo != null) { trip.TownTo = entity.TownTo; }
        if (entity.CompanyId != null) { trip.CompanyId = (Guid)entity.CompanyId; }
        await _tripService.Save();
    }

    public async Task Edit(Y entity, Guid id, int? PlaneId)
    {
        var trip = await _tripService.GetPlaneTipById(id);
        if (entity.TimeIn != null) { trip.TimeIn = (DateTime)entity.TimeIn; }
        if (entity.TimeOut != null) { trip.TimeOut = (DateTime)entity.TimeOut; }
        if (entity.Plane != null) { trip.Plane = entity.Plane; }
        if (entity.TownFrom != null) { trip.TownFrom = entity.TownFrom; }
        if (entity.TownTo != null) { trip.TownTo = entity.TownTo; }
        if (entity.CompanyId != null) { trip.CompanyId = (Guid)entity.CompanyId; }
        if (PlaneId != null) { trip.PlaneId = (int)PlaneId; }
        await _tripService.Save();
    }

    public Task Delete(Guid id)
    {
        return _tripService.Delete(id);
    }
}
