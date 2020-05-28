using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webapiclient2.Models
{
    public class FlightBooking
    {
        [Key]
        public int FlightNo { get; set; }

        public string Departure { get; set; }

        [StringLength(50), MinLength(3)]
        public string Destination { get; set; }

        public DateTime Date { get; set; }

        public short? AvailableSeats { get; set; }

        [Required]
        public short? Seats { get; set; }

        [Required]
        public float TicketPrice { get; set; }

        [Required]
        public string Username { get; set; }
    }
}
