using EfCoreMigrations.Services.Implementations;
using EfCoreMigrations.Services.Interfaces;

namespace EfCoreMigrations.BuilderServices;

public static class DependencyInjectionBuilderService
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services, Microsoft.Extensions.Configuration.ConfigurationManager builder)
    {
        services.AddTransient<IMigrateService, MigrateService>();
        services.AddTransient<IEntityPoster, EntityPoster>();
        return services;
    }
}
