using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities
{
    [Table("vip_passengers")]
    public class VipPassengerEntity:PassengerEntity
    {
        [Column("vip_before_date")]
        public DateTime VipBeforeDate { get; set; }

        [Column(TypeName = "jsonb")]
        public string JsonData { get; set; }
    }
}
