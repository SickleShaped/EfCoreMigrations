using EfCoreMigrations.DB.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EfCoreMigrations;

public class ApiDbContext : DbContext
{
    public ApiDbContext() => Database.EnsureCreated();
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { Database.SetCommandTimeout(150000); }

    /// <summary>
    /// DBSet Компаний
    /// </summary>
    public DbSet<CompanyEntity> Companies { get; set; } = null!;
    /// <summary>
    /// DBSet Пассажиров
    /// </summary>
    public DbSet<PassengerEntity> Passengers { get; set; } = null!;
    /// <summary>
    /// DBSet Поездок
    /// </summary>
    public DbSet<TripEntity> Trips { get; set; } = null!;

    /// <summary>
    /// Вспомогательный DbSet для связи многие-ко-многим между таблицами Пассажиров и Поездок
    /// </summary>
    public DbSet<PassengerEntity> PassengerTrips { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}


