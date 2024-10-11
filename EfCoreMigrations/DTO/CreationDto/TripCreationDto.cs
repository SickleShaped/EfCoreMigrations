using EfCoreMigrations.DB.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DTO.CreationDto
{
    public class TripCreationDto: BaseCreationDto
    {
        public Guid CompanyId { get; set; }
        public string TownFrom { get; set; } = default!;
        public string TownTo { get; set; } = default!;
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
    }
}
