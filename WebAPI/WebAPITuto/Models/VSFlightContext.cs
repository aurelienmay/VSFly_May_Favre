using EFCoreApp2020;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITuto.Models
{
    public class VSFlightContext : DbContext
    {
        public DbSet<Flight> FlightSet { get; set; }
        public object BookingSet { get; internal set; }

        public static string ConnectionString { get; set; } = @"Server=(localDB)\MSSQLLocalDB;Database=WWWings_2020Step1;Trusted_Connection=True;MultipleActiveResultSets=True;App=EFCoreApp2020";

        public VSFlightContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // composed
            builder.Entity<Booking>().HasKey(x => new { x.FlightNo, x.PassengerID });

            // mapping many to many relationship
            //builder.Entity<Booking>()
            //    .HasOne(x => x.Flight)
            //    .WithMany(x => x.BookingSet)
            //    .HasForeignKey(x => x.FlightNo)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<Booking>()
            //    .HasOne(x => x.Passenger)
            //    .WithMany(x => x.BookingSet)
            //    .HasForeignKey(x => x.PassengerID)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
