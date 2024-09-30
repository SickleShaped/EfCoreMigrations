namespace EfCoreMigrations.DTO;

public class Trip
{
    public Guid Id { get; set; }
    public Guid CompanyId { get; set; }
    public string Plane { get; set; } = null!;
    public string TownFrom { get; set; } = null!;
    public string TownTo { get; set; } = null!;
    public DateTime TimeIn { get; set; }
    public DateTime TimeOut { get; set; }
}
