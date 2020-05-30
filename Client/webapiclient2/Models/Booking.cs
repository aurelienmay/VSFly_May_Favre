using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webapiclient2.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        public int FlightNo { get; set; }

        public int PassengerID { get; set; }

        public float TicketPrice { get; set; }
    }
}
