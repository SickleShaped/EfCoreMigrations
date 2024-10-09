using AutoMapper;
using EfCoreMigrations.DB;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Repositories.Implementations;
using EfCoreMigrations.Services.Implementations;

namespace EfCoreMigrations;

public class TripUnitOfWork<T, Y> where T : TripEntity where Y : TripCreationDto
{
    private readonly TripService<T> _tripService;
    private readonly IMapper _mapper;
    private TripRepository<T, Y> _tripRepository;

    public TripUnitOfWork(ApiDbContext context, IMapper mapper, TripService<T> tripService)
    {
        _tripService = tripService;
        _mapper = mapper;
    }

    public TripRepository<T, Y> Trips
    {
        get
        {
            if (_tripRepository == null)
                _tripRepository = new TripRepository<T, Y>(_tripService, _mapper);
            return _tripRepository;
        }
    }

}