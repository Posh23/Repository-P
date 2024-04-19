using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastucture.Data.Configuration
{
    public class MagazineConfiguration : IEntityTypeConfiguration<Magazine>
    {
        public void Configure(EntityTypeBuilder<Magazine> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(100); // Максимальная длина названия журнала 100 символов

            builder.Property(m => m.Type)
                .IsRequired()
                .HasMaxLength(100); // Максимальная длина типа журнала 100 символов

            // Устанавливаем внешний ключ для связи с фотосессией
          
        }
    }
}
