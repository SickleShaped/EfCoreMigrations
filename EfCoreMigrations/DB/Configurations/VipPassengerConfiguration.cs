using EfCoreMigrations.DB.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrations.DB.Configurations
{
    /// <summary>
    /// Класс, описывающий конфигурацию Вип-Пассажиров в БД
    /// </summary>
    public class VipPassengerConfiguration : IEntityTypeConfiguration<VipPassengerEntity>
    {
        /// <summary>
        /// Конфигурация Вип-пассажиров в базе данных
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<VipPassengerEntity> builder)
        {
            //builder.HasKey(k => k.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.VipStatus).HasColumnType("jsonb");
        }

    }
}
