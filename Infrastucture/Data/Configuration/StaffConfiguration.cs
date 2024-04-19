using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastucture.Data.Configuration
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100); // Максимальная длина имени 100 символов

            builder.Property(s => s.Position)
                .IsRequired()
                .HasMaxLength(100); // Максимальная длина должности 100 символов

            // Устанавливаем внешний ключ для связи с студией
           
        }
    }
}
