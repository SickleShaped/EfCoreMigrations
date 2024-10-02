using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities
{
    [Table("vip_passengers")]
    public class VipPassengerEntity:PassengerEntity
    {
        public DateTime VipBeforeDate { get; set; } 
    }
}
