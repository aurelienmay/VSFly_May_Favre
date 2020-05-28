using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreApp2020
{
    public class Passenger
    {
        [Key]
        public int PassengerID { get; set; }

        public string Username { get; set; }

        public virtual ICollection<Booking> BookingSet { get; set; }
    }
}
