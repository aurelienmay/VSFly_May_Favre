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
    public class PassengerController : ControllerBase
    {
        private readonly VSFlightContext _context;

        public PassengerController(VSFlightContext context)
        {
            _context = context;
        }

        // GET: api/Passenger
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Passenger>>> GetPassengers()
        {
            return await _context.Passenger.ToListAsync();
        }

        // GET: api/Passenger/username
        [HttpGet("{username}")]
        public async Task<int> GetPassengerUID(string username)
        {
            List<Passenger> passenger = await _context.Passenger.AsQueryable().Where(passenger => passenger.Username == username).ToListAsync();
            try
            {
                return passenger[0].PassengerID;
            }catch(Exception e)
            {
                return 0;
            }
        }

        // POST: api/Passenger
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Passenger/5
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
