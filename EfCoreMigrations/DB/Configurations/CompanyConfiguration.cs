using EfCoreMigrations.DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreMigrations.DB.Configurations
{
    /// <summary>
    /// Класс, описывающий конфигурацию Компаний в БД
    /// </summary>
    public class CompanyConfiguration : IEntityTypeConfiguration<CompanyEntity>
    {
        /// <summary>
        /// Конфигурация компаний в базе данных
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<CompanyEntity> builder)
        {
            builder.ToTable("companies");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Name).IsRequired();
        }
    }
}
