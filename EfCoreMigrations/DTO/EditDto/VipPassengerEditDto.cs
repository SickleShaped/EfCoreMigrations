namespace EfCoreMigrations.DTO.EditDto
{
    public class VipPassengerEditDto:PassengerEditDto
    {
        public VipStatus? VipStatus { get; set; }
    }
}
