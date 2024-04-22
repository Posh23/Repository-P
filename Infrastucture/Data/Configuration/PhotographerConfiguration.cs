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
                .HasMaxLength(100); 

            builder.Property(p => p.Age)
                .IsRequired();

            builder.Property(p => p.Specialty)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(ph => ph.PhotoSessions)
               .WithMany(p => p.Photographers)
               .HasForeignKey(ph => ph.PhotoSessionId)
               .OnDelete(DeleteBehavior.Cascade);

        }
    }
}

