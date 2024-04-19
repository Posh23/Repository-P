using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastucture.Data.Configuration
{
    public class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(100); // Максимальная длина типа оборудования 100 символов

            builder.Property(e => e.Brand)
                .IsRequired()
                .HasMaxLength(100); // Максимальная длина бренда 100 символов

            builder.Property(e => e.Condition)
                .HasMaxLength(100); // Максимальная длина состояния 100 символов

            builder.Property(e => e.Availability)
                .IsRequired();

            // Здесь можно добавить определение отношений, если они есть для оборудования
        }
    }
}
