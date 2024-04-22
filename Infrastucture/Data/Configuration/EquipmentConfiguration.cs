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
                .HasMaxLength(100); 

            builder.Property(e => e.Brand)
                .IsRequired()
                .HasMaxLength(100); 

            builder.Property(e => e.Condition) 
                .HasMaxLength(100);

            builder.Property(e => e.Availability)
                .IsRequired();

            
        }
    }
}
