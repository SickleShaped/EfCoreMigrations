﻿using EfCoreMigrations.DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreMigrations.DB.Configurations
{
    /// <summary>
    /// Класс, описывающий конфигурацию поездок в БД
    /// </summary>
    public class TripConfiguration : IEntityTypeConfiguration<TripEntity>
    {
        /// <summary>
        /// Конфигурация Поездок в Базе данных
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<TripEntity> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasIndex(k=>k.Id).IsUnique();

            builder.Property(p => p.Plane).IsRequired();
            builder.Property(p => p.TownFrom).IsRequired();
            builder.Property(p => p.TownTo).IsRequired();

            builder
                   .HasOne(p => p.Company)
                   .WithMany(u => u.tripModels)
                   .HasForeignKey(p => p.CompanyId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder
                   .HasMany(t => t.Passengers)
                   .WithMany(p => p.Trips)
                   .UsingEntity<PassengerTripAuxilatyEntity>(
                pt => pt
                    .HasOne(pt => pt.Passenger)
                    .WithMany(p => p.PassengerTrips)
                    .HasForeignKey(pt => pt.PassengerId)
                    .OnDelete(DeleteBehavior.Cascade),
                pt => pt
                    .HasOne(pt => pt.Trip)
                    .WithMany(t => t.PassengerTrips)
                    .HasForeignKey(pt => pt.TripId)
                    .OnDelete(DeleteBehavior.Cascade),
                pt =>
                {
                    pt.HasKey(k => k.Id);
                    pt.HasIndex(i => i.Id).IsUnique();
                    pt.Property(p => p.Place).IsRequired();
                });
        }
    }
}
