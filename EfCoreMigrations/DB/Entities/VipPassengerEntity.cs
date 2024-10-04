using EfCoreMigrations.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities
{
    [Table("vip_passengers")]
    public class VipPassengerEntity:PassengerEntity
    {
        [Required]
        public VipStatus VipStatus { get; set; }
    }
}
