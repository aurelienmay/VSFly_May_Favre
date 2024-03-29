﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreApp2020;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
            return await _context.FlightSet.AsQueryable().Where(flight => flight.AvailableSeats != 0 && flight.Date > DateTime.Today).OrderBy(a => a.Date).ToListAsync();
        }

        // GET: api/Flights/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Flight>> GetFlight(int id)
        {
            var flight = await _context.FlightSet.FindAsync(id);

            DateTime today = DateTime.Today;

            double freeplacepercent = (double) flight.AvailableSeats / (double)flight.Seats * 100;
            int day = 0;
            if(today.Day > flight.Date.Day)
            {
                day = 1;
            }
            int betweenDate = Math.Abs((today.Year * 12 + today.Month) - (flight.Date.Year * 12 + flight.Date.Month-day));

                if (freeplacepercent < 20)
                {
                    flight.BasePrice *= (float)1.5;
                return flight;
                }
                if (freeplacepercent > 80 && betweenDate < 2 && betweenDate >= 1)
                {
                    flight.BasePrice *= (float)0.8;
                return flight;
                }
                if (freeplacepercent > 50 && betweenDate < 1)
                {
                    flight.BasePrice *= (float)0.7;
                return flight;
            }
            
            if (flight == null)
            {
                return NotFound();
            }

            return flight;
        }

        // PUT: api/ToDoItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlight(int id)
        {
            var flight = await _context.FlightSet.FindAsync(id);

            if (flight == null)
            {
                return NotFound();
            }

            flight.AvailableSeats--;

            _context.Entry(flight).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
