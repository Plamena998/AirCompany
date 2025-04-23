using AirCompany.BaseModels;
using AirCompany.Models;
using DataContext;
using DataContext.Contracts;
using DataContext.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DataContext
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightStatus> FlightStatuses { get; set; }
        public DbSet<FlightStatusChange> FlightStatusChanges { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-RDQ454BS\\SQLEXPRESS;Database='AirCompany'; Trusted_Connection=True; TrustServerCertificate = True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed.DataSeed.ExampleSeed(modelBuilder);
            modelBuilder.Entity<Payroll>()
            .HasOne(p => p.Ticket)
            .WithOne(t => t.Payroll)
            .HasForeignKey<Ticket>(t => t.PayrollId);
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            List<EntityEntry> entries = ChangeTracker.Entries()
                .Where(x => x.Entity.GetType() is IBaseModel).ToList();

            foreach (var entry in entries)
            {
                IBaseModel model = (IBaseModel)entry.Entity;
                if (entry.State == EntityState.Added)
                {
                    model.CreatedAt = DateTimeOffset.UtcNow;
                }
                else if (entry.State == EntityState.Modified)
                {
                    model.UpdatedAt = DateTimeOffset.UtcNow;
                }
                else if (entry.State == EntityState.Deleted)
                {
                    model.DeletedAt = DateTimeOffset.UtcNow;
                    entry.State = EntityState.Modified;
                }
            }
            return base.SaveChanges();
        }

    }
}