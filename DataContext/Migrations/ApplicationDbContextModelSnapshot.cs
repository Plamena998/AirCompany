﻿// <auto-generated />
using System;
using DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataContext.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AirCompany.Models.Airplane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("CrewId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("SeatsCount")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CrewId");

                    b.ToTable("Airplanes");
                });

            modelBuilder.Entity("AirCompany.Models.Airport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AirplaneId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("AirplaneId");

                    b.HasIndex("CityId");

                    b.ToTable("Airports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 4, 11, 21, 20, 51, 355, DateTimeKind.Unspecified).AddTicks(1383), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Sofia International Airport EAD"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 4, 11, 21, 20, 51, 355, DateTimeKind.Unspecified).AddTicks(1387), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Bucharest International Airport EAD"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 4, 11, 21, 20, 51, 355, DateTimeKind.Unspecified).AddTicks(1389), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Belgrad Henri Coandă Airport"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 4,
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 4, 11, 21, 20, 51, 355, DateTimeKind.Unspecified).AddTicks(1390), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Beijing Capital International Airport"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 5,
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 4, 11, 21, 20, 51, 355, DateTimeKind.Unspecified).AddTicks(1391), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Tokyo Airport"
                        });
                });

            modelBuilder.Entity("AirCompany.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Sofia",
                            CountryId = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Bucharest",
                            CountryId = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Belgrad",
                            CountryId = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 4,
                            CityName = "Beijing",
                            CountryId = 4,
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 5,
                            CityName = "Tokyo",
                            CountryId = 5,
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("AirCompany.Models.Continent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContinentName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Continents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContinentName = "Europe",
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 4, 11, 21, 20, 51, 354, DateTimeKind.Unspecified).AddTicks(9909), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 2,
                            ContinentName = "Asia",
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 4, 11, 21, 20, 51, 355, DateTimeKind.Unspecified).AddTicks(333), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("AirCompany.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContinentId")
                        .HasColumnType("int");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("ContinentId");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContinentId = 1,
                            CountryName = "Bulgaria",
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 4, 11, 21, 20, 51, 355, DateTimeKind.Unspecified).AddTicks(506), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 2,
                            ContinentId = 1,
                            CountryName = "Romania",
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 4, 11, 21, 20, 51, 355, DateTimeKind.Unspecified).AddTicks(665), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 3,
                            ContinentId = 1,
                            CountryName = "Serbia",
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 4, 11, 21, 20, 51, 355, DateTimeKind.Unspecified).AddTicks(706), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 4,
                            ContinentId = 2,
                            CountryName = "China",
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 4, 11, 21, 20, 51, 355, DateTimeKind.Unspecified).AddTicks(707), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 5,
                            ContinentId = 2,
                            CountryName = "Japan",
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 4, 11, 21, 20, 51, 355, DateTimeKind.Unspecified).AddTicks(709), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("AirCompany.Models.Crew", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("FlightId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.HasIndex("RoleId");

                    b.ToTable("Crews");
                });

            modelBuilder.Entity("AirCompany.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AirplaneId")
                        .HasColumnType("int");

                    b.Property<int?>("AirportId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("FlightDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("FlightDuration")
                        .HasColumnType("int");

                    b.Property<int>("PassengersCount")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("AirplaneId");

                    b.HasIndex("AirportId");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FlightDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FlightDuration = 1,
                            PassengersCount = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FlightDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FlightDuration = 2,
                            PassengersCount = 0
                        });
                });

            modelBuilder.Entity("AirCompany.Models.FlightStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("FlightStatuses");
                });

            modelBuilder.Entity("AirCompany.Models.FlightStatusChange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ChangedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("FlightId")
                        .HasColumnType("int");

                    b.Property<int>("FlightStatusId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.HasIndex("FlightStatusId");

                    b.ToTable("FlightStatusChanges");
                });

            modelBuilder.Entity("AirCompany.Models.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("FlightId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.ToTable("Passengers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Maria Ivanova",
                            TicketId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Dimitar Gogov",
                            TicketId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Ivan Slavov",
                            TicketId = 3
                        });
                });

            modelBuilder.Entity("AirCompany.Models.Payroll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("TicketId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Payrolls");
                });

            modelBuilder.Entity("AirCompany.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AirCompany.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("FlightId")
                        .HasColumnType("int");

                    b.Property<bool>("PaymentSuccess")
                        .HasColumnType("bit");

                    b.Property<int?>("PayrollId")
                        .HasColumnType("int");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.HasIndex("PayrollId")
                        .IsUnique()
                        .HasFilter("[PayrollId] IS NOT NULL");

                    b.HasIndex("UserId1");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("AirCompany.Models.Airplane", b =>
                {
                    b.HasOne("AirCompany.Models.Crew", null)
                        .WithMany("Airplanes")
                        .HasForeignKey("CrewId");
                });

            modelBuilder.Entity("AirCompany.Models.Airport", b =>
                {
                    b.HasOne("AirCompany.Models.Airplane", null)
                        .WithMany("Airports")
                        .HasForeignKey("AirplaneId");

                    b.HasOne("AirCompany.Models.City", "City")
                        .WithMany("Airports")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("AirCompany.Models.City", b =>
                {
                    b.HasOne("AirCompany.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("AirCompany.Models.Country", b =>
                {
                    b.HasOne("AirCompany.Models.Continent", "Continent")
                        .WithMany("Countries")
                        .HasForeignKey("ContinentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Continent");
                });

            modelBuilder.Entity("AirCompany.Models.Crew", b =>
                {
                    b.HasOne("AirCompany.Models.Flight", null)
                        .WithMany("Crews")
                        .HasForeignKey("FlightId");

                    b.HasOne("AirCompany.Models.Role", "Role")
                        .WithMany("Crews")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("AirCompany.Models.Flight", b =>
                {
                    b.HasOne("AirCompany.Models.Airplane", null)
                        .WithMany("Flights")
                        .HasForeignKey("AirplaneId");

                    b.HasOne("AirCompany.Models.Airport", null)
                        .WithMany("Flights")
                        .HasForeignKey("AirportId");
                });

            modelBuilder.Entity("AirCompany.Models.FlightStatusChange", b =>
                {
                    b.HasOne("AirCompany.Models.Flight", "Flight")
                        .WithMany("FlightStatusChanges")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirCompany.Models.FlightStatus", "MyProperty")
                        .WithMany("FlightStatusChanges")
                        .HasForeignKey("FlightStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("MyProperty");
                });

            modelBuilder.Entity("AirCompany.Models.Passenger", b =>
                {
                    b.HasOne("AirCompany.Models.Flight", null)
                        .WithMany("Passengers")
                        .HasForeignKey("FlightId");
                });

            modelBuilder.Entity("AirCompany.Models.Ticket", b =>
                {
                    b.HasOne("AirCompany.Models.Flight", "Flight")
                        .WithMany()
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirCompany.Models.Payroll", "Payroll")
                        .WithOne("Ticket")
                        .HasForeignKey("AirCompany.Models.Ticket", "PayrollId");

                    b.HasOne("AirCompany.Models.Passenger", "User")
                        .WithMany()
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("Payroll");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AirCompany.Models.Airplane", b =>
                {
                    b.Navigation("Airports");

                    b.Navigation("Flights");
                });

            modelBuilder.Entity("AirCompany.Models.Airport", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("AirCompany.Models.City", b =>
                {
                    b.Navigation("Airports");
                });

            modelBuilder.Entity("AirCompany.Models.Continent", b =>
                {
                    b.Navigation("Countries");
                });

            modelBuilder.Entity("AirCompany.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("AirCompany.Models.Crew", b =>
                {
                    b.Navigation("Airplanes");
                });

            modelBuilder.Entity("AirCompany.Models.Flight", b =>
                {
                    b.Navigation("Crews");

                    b.Navigation("FlightStatusChanges");

                    b.Navigation("Passengers");
                });

            modelBuilder.Entity("AirCompany.Models.FlightStatus", b =>
                {
                    b.Navigation("FlightStatusChanges");
                });

            modelBuilder.Entity("AirCompany.Models.Payroll", b =>
                {
                    b.Navigation("Ticket")
                        .IsRequired();
                });

            modelBuilder.Entity("AirCompany.Models.Role", b =>
                {
                    b.Navigation("Crews");
                });
#pragma warning restore 612, 618
        }
    }
}
