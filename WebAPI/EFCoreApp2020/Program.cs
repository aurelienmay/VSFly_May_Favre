using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreApp2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DateTime today = DateTime.Today;

            Console.WriteLine(today);

            int betweenDate = Math.Abs((today.Year * 12 + today.Month) - (2020 * 12 + 06));

            Console.WriteLine(betweenDate);

            // int betweenDate = (today.Year * 12 + today.Month) - (2020 * 12 + flight.Date.Year);


            //CreateDatabase();

            NewFlights(); // create the flight n° 1 + n° 2 + n° 3

            //PrintFlights();

            //NewBooking();

            //UpdateFlights(); // use the flight n° 1

            //PrintFlights();

            //DeleteFlights(); // delete the last flight

            //PrintFlights();
        }

        private static void CreateDatabase()
        {
            using (var ctx = new WWWingsContext())
            {
                var e = ctx.Database.EnsureCreated();

                if (e)
                    Console.WriteLine("Database has been created !");
            }
        }
        private static void UpdateFlights()
        {
            using (var ctx = new WWWingsContext()) {
                // update seats of the first flight in the database
                Flight flight = ctx.FlightSet.Find(1);

                flight.Seats += 1;

                ctx.SaveChanges();
            }
        }

        private static void DeleteFlights()
        {
            using (var ctx = new WWWingsContext()) {
                // delete the flight we just add

                int key = (from f in ctx.FlightSet
                         select f.FlightNo).Max();      // MAX function

                Console.WriteLine("* Delete flight with key = {0}", key);

                Flight flight = ctx.FlightSet.Find(key);

                ctx.FlightSet.Remove(flight);

                ctx.SaveChanges();
            }
        }

        private static void NewFlights()
        {
            using (var ctx = new WWWingsContext())
            {
                // add a Flight in FlightSet .... with Linq language 
                Flight flight1 = new Flight { Departure = "GVA", Destination = "LAX", Seats = 350, Date = new DateTime() };
                ctx.FlightSet.Add(flight1);

                Flight flight2 = new Flight { Departure = "LAX", Destination = "GVA", Seats = 350, Date = new DateTime() };
                ctx.FlightSet.Add(flight2);

                Flight flight3 = new Flight { Departure = "GVA", Destination = "MLN", Seats = 100, Date = new DateTime() };
                ctx.FlightSet.Add(flight3);

                ctx.SaveChanges();
            }
        }

        private static void PrintFlights()
        {
            Console.WriteLine("--------------------------------------------------------");

            using (var ctx = new WWWingsContext())
            {
                // Linq
                // needs using System.Linq;
                var q = from f in ctx.FlightSet
                            // where f.Departure.StartsWith("G")  
                        select f;

                foreach (Flight f in q)
                {

                    Console.WriteLine("{0} {1} {2}", f.FlightNo, f.Destination, f.Seats);

                }
            }
        }
    }
}
