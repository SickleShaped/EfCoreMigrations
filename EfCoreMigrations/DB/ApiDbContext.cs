using EfCoreMigrations.DB.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Emit;

namespace EfCoreMigrations.DB;

public class ApiDbContext : DbContext
{
    public ApiDbContext() => Database.EnsureCreated();
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { Database.SetCommandTimeout(150000); }
    public DbSet<CompanyEntity> Companies { get; set; } = null!;
    public DbSet<StateOwnedCompanyEntity> StateOwnedCompanies { get; set; } = null!;
    public DbSet<PassengerEntity> Passengers { get; set; } = null!;
    public DbSet<VipPassengerEntity> VipPassengerEntities { get; set; } = null!;
    public DbSet<TripEntity> Trips { get; set; } = null!;
    public DbSet<PlaneTripEntity> PlaneTrips { get; set; } = null!;
    public DbSet<PassengerEntity> PassengerTrips { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
        builder.Entity<PassengerEntity>().UseTpcMappingStrategy();
        builder.Entity<TripEntity>().UseTphMappingStrategy();
    }
}