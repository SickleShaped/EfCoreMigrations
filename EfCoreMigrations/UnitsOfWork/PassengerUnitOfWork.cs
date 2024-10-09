using AutoMapper;
using EfCoreMigrations.DB;
using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Repositories.Implementations;
using EfCoreMigrations.Repositories.Interfaces;
using EfCoreMigrations.Services.Implementations;

namespace EfCoreMigrations.UnitsOfWork;

public class PassengerUnitOfWork<T, Y> where T:PassengerEntity where Y:PassengerCreationDto
{
    private readonly PassengerService<T> _passengerService;
    private readonly IMapper _mapper;
    private  PassengerRepository<T, Y> _passengerRepository;
    
    public PassengerUnitOfWork(ApiDbContext context, IMapper mapper, PassengerService<T> passengerService)
    {
        _passengerService = passengerService;
        _mapper = mapper;
    }

    public PassengerRepository<T,Y> Passengers
    {
        get
        {
            if (_passengerRepository == null)
                _passengerRepository = new PassengerRepository<T, Y>(_passengerService , _mapper);
            return _passengerRepository;
        }
    }

}
