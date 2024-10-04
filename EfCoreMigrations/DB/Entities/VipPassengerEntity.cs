using EfCoreMigrations.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities
{
    [Table("vip_passengers")]
    public class VipPassengerEntity : PassengerEntity
    {
        [Required]
        [Column("vip_status", TypeName = "jsonb")]
        public VipStatus VipStatus { get; set; }
    }
}
