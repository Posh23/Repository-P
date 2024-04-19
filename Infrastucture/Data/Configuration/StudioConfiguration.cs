using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastucture.Data.Configuration
{
    public class StudioConfiguration : IEntityTypeConfiguration<Studio>
    {
        public void Configure(EntityTypeBuilder<Studio> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100); // Максимальная длина названия студии 100 символов

            builder.Property(s => s.Address)
                .IsRequired()
                .HasMaxLength(200); // Максимальная длина адреса студии 200 символов

            // Устанавливаем внешний ключ для связи с оборудованием

        }
    }
}
