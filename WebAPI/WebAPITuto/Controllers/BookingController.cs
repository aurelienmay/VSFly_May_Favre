﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreApp2020;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPITuto.Models;

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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Booking/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        //// POST: api/Booking
        //[HttpPost]
        //public async Task<ActionResult<Booking>> PostBooking(Booking booking)
        //{
        //    _context.BookingSet.Add(booking);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(GetToDoItem), new { id = flight.Id }, flight);
        //}

        // POST: api/Booking
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
