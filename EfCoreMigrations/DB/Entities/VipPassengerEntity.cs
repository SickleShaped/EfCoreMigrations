using EfCoreMigrations.DTO;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities
{
    [Table("vip_passengers")]
    public class VipPassengerEntity:PassengerEntity
    {
        [Column(TypeName = "jsonb")]
        public VipStatus JsonData { get; set; }
    }
}
