using EfCoreMigrations.DB.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.DB.Configurations
{
    public class PassengerTripsConfiguration : IEntityTypeConfiguration<PassengerTripAuxilatyEntity>
    {
        /// <summary>
        /// Конфигурация вспомогательной таблицы для связи многие ко многим между таблицей пассажиров и таблицей поездок
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<PassengerTripAuxilatyEntity> builder)
        {
            builder.HasKey(c => new { c.TripId, c.PassengerId });
            builder.Property(p => p.Place).IsRequired();
        }
    }
}
