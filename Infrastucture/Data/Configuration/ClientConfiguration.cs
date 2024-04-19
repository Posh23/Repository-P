using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastucture.Data.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100); // Максимальная длина имени 100 символов

            builder.Property(c => c.Phone)
                .HasMaxLength(20); // Максимальная длина номера телефона 20 символов

            builder.Property(c => c.Email)
                .HasMaxLength(100); // Максимальная длина email 100 символов

            // Здесь можно добавить определение отношений, если они есть для клиента
        }
    }
}
