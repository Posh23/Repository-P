using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastucture.Data.Configuration
{
    public class PhotographerConfiguration : IEntityTypeConfiguration<Photographer>
    {
        public void Configure(EntityTypeBuilder<Photographer> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100); // Максимальная длина имени 100 символов

            builder.Property(p => p.Age)
                .IsRequired();

            builder.Property(p => p.Specialty)
                .IsRequired()
                .HasMaxLength(100); // Максимальная длина специализации 100 символов

          

            // Методы для работы с фотографиями могут быть определены как отдельные методы в классе Photographer,
            // поскольку они, вероятно, будут зависеть от бизнес-логики вашего приложения.
        }
    }
}

