namespace EfCoreMigrations.DTO;

public record Passenger
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
}
