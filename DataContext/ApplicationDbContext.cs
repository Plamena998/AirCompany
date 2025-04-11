using AirCompany.BaseModels;
using AirCompany.Models;
using DataContext;
using DataContext.Contracts;
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

        public List<Ticket> BuyingTickets()
        {
            var passenger = new Passenger{Name="Boris Mihov"};
            var passenger2 = new Passenger { Name = "Verda Stoeva" };
            var passenger3 = new Passenger { Name = "Silia Doynova" };

            Passengers.AddRange(passenger,passenger2,passenger3);
            SaveChanges();

            var flights = new List<Flight>
            {
            new Flight ()
                {
                FlightDuration=120, //minutes
                FlightDate= DateTimeOffset.UtcNow,
                PassengersCount=0,
                Crews=new List<Crew>(),
                FlightStatusChanges=new List<FlightStatusChange>(),
                Passengers = new List<Passenger>()
                },
            new Flight()
            {
             FlightDuration=60, //minutes
                FlightDate= DateTimeOffset.Now.AddDays(3),
                PassengersCount=0,
                Crews=new List<Crew>(),
                FlightStatusChanges=new List<FlightStatusChange>(),
                Passengers = new List<Passenger>()
            },
            new Flight()
            {
             FlightDuration=78, //minutes
                FlightDate= DateTimeOffset.Now.AddHours(8),
                PassengersCount=0,
                Crews=new List<Crew>(),
                FlightStatusChanges=new List<FlightStatusChange>(),
                Passengers = new List<Passenger>()
            },
            new Flight()
            {
             FlightDuration=180, //minutes
                FlightDate= DateTimeOffset.Now.AddHours(12),
                PassengersCount=0,
                Crews=new List<Crew>(),
                FlightStatusChanges=new List<FlightStatusChange>(),
                Passengers = new List<Passenger>()
            },
            new Flight()
            {
             FlightDuration=43, //minutes
                FlightDate= DateTimeOffset.Now.AddDays(1),
                PassengersCount=0,
                Crews=new List<Crew>(),
                FlightStatusChanges=new List<FlightStatusChange>(),
                Passengers = new List<Passenger>()
            },
            new Flight()
            {
             FlightDuration=200, //minutes
                FlightDate= DateTimeOffset.UtcNow,
                PassengersCount=0,
                Crews=new List<Crew>(),
                FlightStatusChanges=new List<FlightStatusChange>(),
                Passengers = new List<Passenger>()
            },            };
            Flights.AddRange(flights);
            SaveChanges();

            var passengerFlights = new List<Flight>()
            {
                flights[2], flights[3], flights[5]
            };
            var passenger2Flights = new List<Flight>()
            {
                flights[0], flights[2], flights[3]
            };
            var passenger3Flights = new List<Flight>()
            {
                flights[1], flights[4], flights[5]
            };

            var tickets = new List<Ticket>();

            var passengerTickets = BuyingTicketPerPassenger(passenger, passengerFlights);
            tickets.AddRange(passengerTickets);
            var passenger2Tickets = BuyingTicketPerPassenger(passenger2, passenger2Flights);
            tickets.AddRange(passenger2Tickets);
            var passenger3Tickets = BuyingTicketPerPassenger(passenger3, passenger3Flights);
            tickets.AddRange(passenger3Tickets);
            SaveChanges();
            return tickets;
            
        }
        private List<Ticket> BuyingTicketPerPassenger(Passenger passenger, List<Flight> flights )
        {
            var tickets = new List<Ticket>();
            
            foreach (var flight in flights)
            {
                var ticket = new Ticket()
                {
                    Type=GetRandomTicketType(),
                    SeatNumber=GetRandomSeat(),
                    PaymentSuccess=true,
                    FlightId=flight.Id,
                    UserId=passenger.Id,
                    User=passenger
                };

                var payroll = new Payroll()
                {
                    Ticket = ticket,
                    Total=GetPriceTicket(ticket.Type),
                };
                
                ticket.Payroll = payroll;
                ticket.PayrollId = payroll.Id;
                flight.PassengersCount++;
                flight.Passengers.Add(passenger);
                Payrolls.Add(payroll);
                Tickets.Add(ticket);
                tickets.Add(ticket);
                
            }
            return tickets;
        }

        private string GetRandomTicketType()
        {
            string[] types = {"First Class", "Business","Economy"};
            return types[new Random().Next(0,types.Length)];
        }
        private decimal GetPriceTicket(string ticketType)
        {
            decimal price = 0;
          switch (ticketType)
            {
                case "First Class":
                    price = 400.00m;
                break;
                case "Business":
                    price = 350.00m;
                break;
                case "Economy":
                    price = 200.00m;
                break;
                    default:
                    price = 250.00m;
                    break;
            }
            return price;
        }
        private ushort GetRandomSeat()
        {
            Random random = new Random();
            var seat = random.Next(0, 200);
            return (ushort)seat;
        }
    }
}
