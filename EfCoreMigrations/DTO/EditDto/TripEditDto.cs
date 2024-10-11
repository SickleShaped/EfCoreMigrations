namespace EfCoreMigrations.DTO.EditDto
{
    public class TripEditDto:BaseEditDto
    {
        public Guid? CompanyId { get; set; }
        public string? TownFrom { get; set; }
        public string? TownTo { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
    }
}
