using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastucture.Data.Configuration
{
    public class PhotoSessionConfiguration : IEntityTypeConfiguration<PhotoSession>
    {
        public void Configure(EntityTypeBuilder<PhotoSession> builder)
        {
            builder.HasKey(ps => ps.Id);

            builder.Property(ps => ps.Date)
                .IsRequired();

            builder.Property(ps => ps.Duration)
                .IsRequired();
           
        }
    }
}
