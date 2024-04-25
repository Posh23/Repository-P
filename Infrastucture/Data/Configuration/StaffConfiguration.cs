using Domain.Entities;
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
                .HasMaxLength(100); 

            builder.Property(s => s.Position)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(s => s.Studios)
               .WithMany(st => st.Staffs)
               .HasForeignKey(p => p.StudioId)
               .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
