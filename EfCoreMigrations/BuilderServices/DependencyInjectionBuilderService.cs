using EfCoreMigrations.Services.Implementations;
using EfCoreMigrations.Services.Interfaces;

namespace EfCoreMigrations.BuilderServices;

public static class DependencyInjectionBuilderService
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services, Microsoft.Extensions.Configuration.ConfigurationManager builder)
    {
        services.AddTransient<IMigrateService, MigrateService>();
        //services.AddTransient(typeof(IA<>), typeof(A<>));
        //services.AddTransient<IEntityPoster, EntityPoster>();
        //services.AddTransient<IEntityGetter, EntityGetter>();
        services.AddTransient<IPassengerService, PassengerService>();
        services.AddTransient<ITripService, TripService>();

        services.AddTransient(typeof(ICompanyService<Guid>), typeof(CompanyService<>));
        return services;
    }
}
