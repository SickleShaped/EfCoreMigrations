using EfCoreMigrations.BuilderServices;
using EfCoreMigrations.DB;
using EfCoreMigrations.Services;
using EfCoreMigrations.Services.Implementations;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var connection = builder.Configuration.GetConnectionString("Default");

        // Add services to the container
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddAutoMapper(typeof(AppMapingProfile));
        builder.Services.AddDbContext<ApiDbContext>(options => options.UseNpgsql(connection));
        builder.Services.AddDependencyInjection(builder.Configuration);

        builder.Services.AddHostedService<MigrateHostedService>();
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
