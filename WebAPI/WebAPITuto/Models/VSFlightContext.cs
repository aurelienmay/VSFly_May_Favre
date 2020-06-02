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
        public DbSet<Passenger> Passenger { get; set; }
        public DbSet<Booking> Booking { get; set; }

        public static string ConnectionString { get; set; } = @"Server=(localDB)\MSSQLLocalDB;Database=WWWings_2020Step1;Trusted_Connection=True;MultipleActiveResultSets=True;App=EFCoreApp2020";

        public VSFlightContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(ConnectionString);
        }
    }
}
