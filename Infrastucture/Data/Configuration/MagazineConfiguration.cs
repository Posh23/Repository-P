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
                .HasMaxLength(100); 

            builder.Property(m => m.Type)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(m => m.PhotoSession)
                .WithMany(p => p.Magazines)
                .HasForeignKey(m => m.PhotoSessionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(m => m.Equipment)
               .WithMany(p => p.Magazines)
               .HasForeignKey(m => m.EquiupmentId)
               .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
