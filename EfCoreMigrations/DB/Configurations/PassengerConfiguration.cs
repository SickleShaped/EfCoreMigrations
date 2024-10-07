using EfCoreMigrations.DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreMigrations.DB.Configurations
{
    /// <summary>
    /// Класс, описывающий конфигурацию Пассажиров в БД
    /// </summary>
    public class PassengerConfiguration : IEntityTypeConfiguration<PassengerEntity>
    {
        /// <summary>
        /// Конфигурация пассажиров в базе данных
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<PassengerEntity> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p=>p.Name).IsRequired();
            builder.UseTpcMappingStrategy();
        }
    }
}
