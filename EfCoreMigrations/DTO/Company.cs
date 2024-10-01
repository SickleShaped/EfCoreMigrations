namespace EfCoreMigrations.DTO;

public record Company
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
}
