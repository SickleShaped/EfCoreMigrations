using EfCoreMigrations.DB.Entities;
using EfCoreMigrations.DTO.CreationDto;
using EfCoreMigrations.Services.Implementations;
using EfCoreMigrations.Services.Interfaces;
using System.Runtime.CompilerServices;

namespace EfCoreMigrations.BuilderServices;

public static class DependencyInjectionBuilderService
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services, Microsoft.Extensions.Configuration.ConfigurationManager builder)
    {
        services.AddTransient<IMigrateService, MigrateService>();
        services.AddTransient(typeof(ICompanyService<>), typeof(CompanyService<>));
        services.AddTransient(typeof(ITripService<>), typeof(TripService<>));
        services.AddTransient(typeof(IPassengerService<>), typeof(PassengerService<>));
        services.AddTransient<CompanyUnitOfWork<CompanyEntity, CompanyCreationDto>>();
        return services;
    }
}
