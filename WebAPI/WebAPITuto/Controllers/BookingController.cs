using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreApp2020;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPITuto.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPITuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly VSFlightContext _context;

        public BookingController(VSFlightContext context)
        {
            _context = context;
        }

        // GET: api/Booking
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Booking>>> GetBookings()
        {
            return await _context.Booking.ToListAsync();
        }

        
        // GET: api/Booking/totalprice/1
        [HttpGet("totalprice/{id}")]
        public string GetTotalPrice(int id)
        {
            float totalprice = 0;
            using (var ctx = new VSFlightContext())
            {
                var q = from f in ctx.Booking
                        where f.FlightNo == id
                        select f;

                foreach (Booking f in q)
                {
                    totalprice += f.TicketPrice;
                }
                return "The total price for the flight No " + id + " is: " + totalprice;
            }
        }

        // GET: api/Booking/average/1
        [HttpGet("average/{destination}")]
        public string Get(string destination)
        {
            float average = 0;
            int sum = 0;
            using (var ctx = new VSFlightContext())
            {
                // Linq
                // needs using System.Linq;
                var q = from f in ctx.Booking
                        join g in ctx.FlightSet on f.FlightNo equals g.FlightNo
                        where g.Destination == destination
                        select f;

                foreach (Booking f in q)
                {
                    average += f.TicketPrice;
                    sum++;
                }

                average /= sum;

                return "The average price for the destination " + destination +" is: " + average+" CHF";
            }
        }

        // GET: api/Booking/average/1
        [HttpGet("List/{destination}")]
        public string GetListOfFlightByDestAndUser(string destination)
        {
            string result="";
            using (var ctx = new VSFlightContext())
            {
                // Linq
                // needs using System.Linq;
                var q = from f in ctx.Booking
                        join g in ctx.FlightSet on f.FlightNo equals g.FlightNo
                        join h in ctx.Passenger on f.PassengerID equals h.PassengerID
                        where g.Destination == destination
                        select f;

                
                foreach (Booking f in q)
                {
                 string username = "";
                 var r = from p in ctx.Passenger
                            join b in ctx.Booking on p.PassengerID equals b.PassengerID
                            where f.PassengerID == p.PassengerID
                            select p;
                    foreach(Passenger p in r)
                    {
                        username = p.Username;
                    }
                    result += "Le numéro de passager: " + f.PassengerID + " | Le nom d'utilisateur: " + username + " | Le numéro de réservation: " + f.BookingID + " | Le prix du vol: " + f.TicketPrice + "\n";
                }
                return result;
            }
        }

        // POST: api/Booking
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking booking)
        {
            _context.Booking.Add(booking);
            await _context.SaveChangesAsync();

            return null;
        }

        // PUT: api/Booking/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
