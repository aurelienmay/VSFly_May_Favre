﻿using System;
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

            CreateDatabase();

            NewPilots();

            NewFlights(); // create the flight n° 1 + n° 2 + n° 3

            PrintFlights();

            //NewBooking();

            UpdateFlights(); // use the flight n° 1

            PrintFlights();

            DeleteFlights(); // delete the last flight

            PrintFlights();

            PrintPilots();
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

        public static void NewPilots() {
            using (var ctx = new WWWingsContext()) {
                Pilot p1 = new Pilot { Surname = "Bono", GivenName = "Jean", Salary = 23000 };
                ctx.PilotSet.Add(p1);

                Pilot p2 = new Pilot { Surname = "Tilde", GivenName = "Pierre", Salary = 4800 };
                ctx.PilotSet.Add(p2);   

                ctx.SaveChanges();
            }
        }

        //private static void NewBooking()
        //{
        //    using (var ctx = new WWWingsContext())
        //    {
        //        ctx.BookingSet.Add(new Booking { FlightNo = 1, PassengerID = 1 });

        //        Flight f = ctx.FlightSet.Find(2); 

        //        f.BookingSet.Add(new Booking { FlightNo = f.FlightNo, PassengerID = 1 });

        //        ctx.SaveChanges();
        //    }
        //}

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
                flight1.PilotId = 1;
                ctx.FlightSet.Add(flight1);

                Flight flight2 = new Flight { Departure = "LAX", Destination = "GVA", Seats = 350, Date = new DateTime() };
                flight2.PilotId = 2;
                ctx.FlightSet.Add(flight2);

                Flight flight3 = new Flight { Departure = "GVA", Destination = "MLN", Seats = 100, Date = new DateTime() };
                flight3.Pilot = ctx.PilotSet.Find(2);
                ctx.FlightSet.Add(flight3);

                ctx.SaveChanges();
            }
        }

        private static void PrintPilots()
        {
            Console.WriteLine("--------------------------------------------------------");

            using (var ctx = new WWWingsContext())
            {
                var q = from p in ctx.PilotSet.Include(x => x.FlightAsPilotSet)
                        select p;

                foreach (Pilot p in q)
                {
                    Console.WriteLine("{0} {1} {2} {3}", p.Surname, p.GivenName, p.Salary, p.FlightAsPilotSet.Count());

                    foreach (Flight f in p.FlightAsPilotSet)
                    {
                        Console.WriteLine(" - {0} {1} {2}", f.Departure, f.Destination, f.Seats);
                    }
                }
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
                    // explicit loading
                    ctx.Entry(f).Reference(x => x.Pilot).Load();

                    Console.WriteLine("{0} {1} {2} {3}", f.FlightNo, f.Destination, f.Seats, f.Pilot.Surname);

                }
            }
        }
    }
}
