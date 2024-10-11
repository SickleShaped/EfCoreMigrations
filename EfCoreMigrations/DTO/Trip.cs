namespace EfCoreMigrations.DTO;

public record Trip
{
    public Guid Id { get; set; }
    public Guid CompanyId { get; set; }
    public string TownFrom { get; set; } = null!;
    public string TownTo { get; set; } = null!;
    public DateTime TimeIn { get; set; }
    public DateTime TimeOut { get; set; }
}
