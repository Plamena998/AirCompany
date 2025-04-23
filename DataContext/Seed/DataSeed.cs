using AirCompany.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataContext.Seed
{
    public class DataSeed
    {
        private static int ticketId = 1;
        private static int payrollId = 1;

        private static List<Continent> continentsList = new()
        {
            new Continent { Id = 1, ContinentName = "Europe", CreatedAt = DateTime.UtcNow },
            new Continent { Id = 2, ContinentName = "Asia", CreatedAt = DateTime.UtcNow }
        };

        private static List<Country> countriesList = new()
        {
            new Country { Id = 1, CountryName = "Bulgaria", CreatedAt = DateTime.UtcNow, ContinentId = 1 },
            new Country { Id = 2, CountryName = "Romania", CreatedAt = DateTime.UtcNow, ContinentId = 1 },
            new Country { Id = 3, CountryName = "Serbia", CreatedAt = DateTime.UtcNow, ContinentId = 1 },
            new Country { Id = 4, CountryName = "China", CreatedAt = DateTime.UtcNow, ContinentId = 2 },
            new Country { Id = 5, CountryName = "Japan", CreatedAt = DateTime.UtcNow, ContinentId = 2 }
        };

        private static List<City> citiesList = new()
        {
            new City { Id = 1, CityName = "Sofia", CountryId = 1 },
            new City { Id = 2, CityName = "Bucharest", CountryId = 2 },
            new City { Id = 3, CityName = "Belgrad", CountryId = 3 },
            new City { Id = 4, CityName = "Beijing", CountryId = 4 },
            new City { Id = 5, CityName = "Tokyo", CountryId = 5 }
        };

        private static List<Airport> airportsList = new()
        {
            new Airport { Id = 1, Name = "Sofia International Airport", CityId = 1, CreatedAt = DateTime.UtcNow },
            new Airport { Id = 2, Name = "Bucharest International Airport", CityId = 2, CreatedAt = DateTime.UtcNow },
            new Airport { Id = 3, Name = "Belgrad Airport", CityId = 3, CreatedAt = DateTime.UtcNow },
            new Airport { Id = 4, Name = "Beijing Airport", CityId = 4, CreatedAt = DateTime.UtcNow },
            new Airport { Id = 5, Name = "Tokyo Airport", CityId = 5, CreatedAt = DateTime.UtcNow }
        };

        private static List<Passenger> passengersList = new()
        {
            new Passenger { Id = 1, Name = "Boris Mihov" },
            new Passenger { Id = 2, Name = "Verda Stoeva" },
            new Passenger { Id = 3, Name = "Silia Doynova" }
        };

        private static List<Flight> flightList = new()
        {
            new Flight { Id = 1, FlightDuration = 120, FlightDate = DateTimeOffset.UtcNow, PassengersCount = 0 },
            new Flight { Id = 2, FlightDuration = 60, FlightDate = DateTimeOffset.UtcNow.AddDays(3), PassengersCount = 0 },
            new Flight { Id = 3, FlightDuration = 78, FlightDate = DateTimeOffset.UtcNow.AddHours(8), PassengersCount = 0 },
            new Flight { Id = 4, FlightDuration = 180, FlightDate = DateTimeOffset.UtcNow.AddHours(12), PassengersCount = 0 },
            new Flight { Id = 5, FlightDuration = 43, FlightDate = DateTimeOffset.UtcNow.AddDays(1), PassengersCount = 0 },
            new Flight { Id = 6, FlightDuration = 200, FlightDate = DateTimeOffset.UtcNow, PassengersCount = 0 }
        };

        private static List<Ticket> ticketsList = new();
        private static List<Payroll> payrollList = new();

        public static void ExampleSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Continent>().HasData(continentsList);
            modelBuilder.Entity<Country>().HasData(countriesList);
            modelBuilder.Entity<City>().HasData(citiesList);
            modelBuilder.Entity<Airport>().HasData(airportsList);
            modelBuilder.Entity<Passenger>().HasData(passengersList);
            modelBuilder.Entity<Flight>().HasData(flightList);

        }

        public static void SeedPassengersFlightsAndTickets(ApplicationDbContext context)
        {
            if (context.Tickets.Any())
                return;

            var passengers = context.Passengers.ToList();
            var flights = context.Flights.ToList();

            var passengerFlightAssignments = new Dictionary<int, List<int>>
            {
                { 1, new List<int> { 3, 4, 6 } }, 
                { 2, new List<int> { 1, 3, 4 } }, 
                { 3, new List<int> { 2, 5, 6 } }  
            };

            foreach (var passenger in passengers)
            {
                if (!passengerFlightAssignments.ContainsKey(passenger.Id))
                    continue;

                var flightIds = passengerFlightAssignments[passenger.Id];
                foreach (var flightId in flightIds)
                {
                    var flight = flights.FirstOrDefault(f => f.Id == flightId);
                    if (flight == null)
                        continue;

                    var type = GetRandomTicketType(new Random());
                    var payroll = new Payroll
                    {
                        Total = GetPriceTicket(type)
                    };

                    context.Payrolls.Add(payroll);
                    context.SaveChanges();

                    var ticket = new Ticket
                    {
                        Type = type,
                        SeatNumber = (ushort)new Random().Next(1, 200),
                        PaymentSuccess = true,
                        FlightId = flight.Id,
                        UserId = passenger.Id,
                        PayrollId = payroll.Id
                    };

                    context.Tickets.Add(ticket);
                    context.SaveChanges();

                    payroll.TicketId = ticket.Id;
                    context.Payrolls.Update(payroll);

                    flight.PassengersCount++;
                    context.Flights.Update(flight);

                    context.SaveChanges();
                }
            }
        }

        private static string GetRandomTicketType(Random rand)
        {
            string[] types = { "First Class", "Business", "Economy" };
            return types[rand.Next(types.Length)];
        }

        private static decimal GetPriceTicket(string type) => type switch
        {
            "First Class" => 400m,
            "Business" => 350m,
            "Economy" => 200m,
            _ => 250m
        };
    }
}