using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Data.Configuration
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Photographer> Photographers { get; set; }
        public DbSet<PhotoSession> PhotoSessions { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<Magazine> Magazines { get; set; }
    }
}
