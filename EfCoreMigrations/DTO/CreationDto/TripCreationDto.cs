using EfCoreMigrations.DB.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DTO.CreationDto
{
    public class TripCreationDto: BaseCreationDto
    {
        public Guid? CompanyId { get; set; }
        public string? Plane { get; set; }
        public string? TownFrom { get; set; }
        public string? TownTo { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
    }
}
