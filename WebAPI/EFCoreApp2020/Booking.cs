using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreApp2020
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        public int FlightNo { get; set; }

        public int PassengerID { get; set; }

        public float TicketPrice { get; set; }

        //public virtual Flight Flight { get; set; }

        //public virtual Passenger Passenger { get; set; }
    }
}