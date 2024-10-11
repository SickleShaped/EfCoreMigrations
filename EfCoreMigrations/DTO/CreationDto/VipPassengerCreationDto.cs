namespace EfCoreMigrations.DTO.CreationDto
{
    public class VipPassengerCreationDto:PassengerCreationDto
    {
        public VipStatus VipStatus { get; set; }
    }
}
