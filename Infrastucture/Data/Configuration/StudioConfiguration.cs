using Domain.Entities;
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
                .HasMaxLength(100); 

            builder.Property(s => s.Address)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasOne(st => st.Equipments)
               .WithMany(e => e.Studios)
               .HasForeignKey(st => st.EquipmentId)
               .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
