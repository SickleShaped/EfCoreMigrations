using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Repositories;
using EfCoreMigrations.Services.Implementations;
using EfCoreMigrations.Services.Interfaces;
using EfCoreMigrations.UnitsOfWork;
using System.Runtime.CompilerServices;

namespace EfCoreMigrations.BuilderServices;

public static class DependencyInjectionBuilderService
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        services.AddTransient<IMigrateService, MigrateService>();
        services.AddTransient<ICompanyService, CompanyService>(); 
        services.AddTransient<IPassengerService, PassengerService>();
        services.AddTransient<ITripService, TripService>();

        services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        //services.AddTransient(typeof(ICompanyService<>), typeof(CompanyService<>));
        //services.AddTransient(typeof(ITripService<>), typeof(TripService<>));
        //services.AddTransient(typeof(IPassengerService<>), typeof(PassengerService<>));

        return services;
    }
}
