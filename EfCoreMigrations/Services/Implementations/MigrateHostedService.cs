using AutoMapper;
using EfCoreMigrations.Services.Interfaces;

namespace EfCoreMigrations.Services.Implementations;

public class MigrateHostedService : BackgroundService
{
    private readonly IServiceProvider _provider;
    public MigrateHostedService(IConfiguration configuration, IServiceProvider provider, IMapper mapper)
    {
        _provider = provider;
    }

    public override Task StartAsync(CancellationToken cancellationToken)
    {
        using (var scope = _provider.CreateScope())
        {
            var x = scope.ServiceProvider.GetRequiredService<IMigrateService>();
            x.Migrate();
        }
        return base.StartAsync(cancellationToken);
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    { }

    public override async Task StopAsync(CancellationToken cancellationToken)
    {
        await base.StopAsync(cancellationToken);
    }
}
