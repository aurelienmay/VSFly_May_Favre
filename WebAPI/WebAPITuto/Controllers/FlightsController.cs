using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreApp2020;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPITuto.Models;

namespace WebAPITuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly VSFlightContext _context;

        public FlightsController(VSFlightContext context)
        {
            _context = context;
        }

        // GET: api/Flights
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flight>>> GetFlights()
        {
            return await _context.FlightSet.AsQueryable().Where(flight => flight.AvailableSeats != 0).ToListAsync();
        }

        // GET: api/Flight/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Flight>> GetFlight(int id)
        {
            var flight = await _context.FlightSet.FindAsync(id);

            DateTime today = DateTime.Today;
            int freeplacepercent = flight.AvailableSeats / flight.Seats * 100;
            int betweenDate = (today.Year * 12 + today.Month) - (flight.Date.Year * 12 + flight.Date.Year);
            if (freeplacepercent >80)
            flight.BasePrice *= (float)1.5;
            if(freeplacepercent <20 && betweenDate < 2)
            {
               // flight.BasePrice=
            }


            


            if (flight == null)
            {
                return NotFound();
            }

            return flight;
        }

        //// PUT: api/ToDoItems/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutToDoItem(long id, ToDoItem toDoItem)
        //{
        //    if (id != toDoItem.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(toDoItem).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ToDoItemExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/ToDoItems
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<ToDoItem>> PostFlight(Flight flight)
        //{
        //    _context.FlightSet.Add(flight);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(GetToDoItem), new { id = flight.Id }, flight);
        //}

        // DELETE: api/ToDoItems/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<ToDoItem>> DeleteToDoItem(long id)
        //{
        //    var toDoItem = await _context.FlightSet.FindAsync(id);
        //    if (toDoItem == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.FlightSet.Remove(toDoItem);
        //    await _context.SaveChangesAsync();

        //    return toDoItem;
        //}

        //private bool ToDoItemExists(long id)
        //{
        //    return _context.ToDoItems.Any(e => e.Id == id);
        //}
    }
}
