﻿using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.DTO.EditDto;

namespace EfCoreMigrations.Services.Interfaces
{
    public interface ITripService : IServiceBase<TripEntity, TripCreationDto, TripEditDto>
    {

    }
}
