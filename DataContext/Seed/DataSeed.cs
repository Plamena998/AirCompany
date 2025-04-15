using AirCompany.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext.Seed
{
    public class DataSeed
    {
        #region Continents
        private static List<Continent> continentsList = new List<Continent>()
        {
            new Continent()
            {
                Id =1,
                ContinentName ="Europe",
                CreatedAt = DateTime.UtcNow,

            },
            new Continent()
            {
                Id = 2,
                ContinentName ="Asia",
                CreatedAt = DateTime.UtcNow,
            }
        };
        private static List<Country> countriesList = new List<Country>()
        {
            new Country()
            {
            Id = 1,
            CountryName="Bulgaria",
            CreatedAt= DateTime.UtcNow,
            ContinentId=continentsList[0].Id
            },
            new Country()
            {
            Id = 2,
            CountryName="Romania",
            CreatedAt= DateTime.UtcNow,
            ContinentId=continentsList[0].Id
            },
            new Country()
            {
            Id = 3,
            CountryName="Serbia",
            CreatedAt= DateTime.UtcNow,
            ContinentId=continentsList[0].Id
            },
            new Country()
            {
            Id = 4,
            CountryName="China",
            CreatedAt= DateTime.UtcNow,
            ContinentId=continentsList[1].Id
            },
             new Country()
            {
            Id = 5,
            CountryName="Japan",
            CreatedAt= DateTime.UtcNow,
            ContinentId=continentsList[1].Id
            }
        };
        #endregion

        private static List<City> citiesList = new List<City>()
        {
            new City()
            {
                Id = 1,
                CityName="Sofia",
                CountryId =countriesList[0].Id
            },
            new City()
            {
                Id = 2,
                CityName="Bucharest",
                CountryId =countriesList[1].Id
            },
            new City()
            {
            Id = 3,
            CityName="Belgrad",
            CountryId=countriesList[2].Id
            },
            new City()
            {
             Id = 4,
             CityName="Beijing",
             CountryId=countriesList[3].Id
            },
            new City()
            {
             Id = 5,
             CityName="Tokyo",
             CountryId=countriesList[4].Id
            }

        };
        private static List<Airport> airportsList = new List<Airport>()
        {
           new Airport()
           {
               Id=1,
           Name="Sofia International Airport EAD",
           CityId=citiesList[0].Id,
           CreatedAt=DateTime.UtcNow
           },
           new Airport()
           {
               Id=2,
               Name = "Bucharest International Airport EAD",
               CityId=citiesList[1].Id,
               CreatedAt=DateTime.UtcNow
           },
           new Airport()
           {
               Id=3,
               Name = "Belgrad Henri Coandă Airport",
               CityId=citiesList[2].Id,
               CreatedAt=DateTime.UtcNow
           },
           new Airport()
           {
               Id=4,
               Name = "Beijing Capital International Airport",
               CityId=citiesList[3].Id,
               CreatedAt=DateTime.UtcNow
           },
           new Airport()
           {
               Id=5,
               Name = "Tokyo Airport",
               CityId=citiesList[4].Id,
               CreatedAt=DateTime.UtcNow
           }
        };
        private static List<Flight> flightList = new List<Flight>()
        {
         new Flight()
         {
             Id = 1,
             FlightDuration = 1,
         },
         new Flight()
         {
             Id =2,
             FlightDuration = 2,
         },
        };
        private static List<Passenger> passengersList = new List<Passenger>
        {
            new Passenger
            {
                Id = 1,
                Name = "Maria Ivanova",
                TicketId =1
            },
             new Passenger
            {
                Id = 2,
                Name = "Dimitar Gogov",
                TicketId =2
            },
             new Passenger
            {
                Id = 3,
                Name = "Ivan Slavov",
                TicketId =3
            },
        };


        public static void ExampleSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Continent>().HasData(continentsList);
            modelBuilder.Entity<Country>().HasData(countriesList);
            modelBuilder.Entity<City>().HasData(citiesList);
            modelBuilder.Entity<Airport>().HasData(airportsList);
            modelBuilder.Entity<Flight>().HasData(flightList);
            modelBuilder.Entity<Passenger>().HasData(passengersList);
        }
    }
}