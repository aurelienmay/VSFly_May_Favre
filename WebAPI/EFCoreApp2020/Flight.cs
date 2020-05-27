﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreApp2020
{
    public class Flight
    {
        public Flight() { }

        [Key]
        public int FlightNo { get; set; }

        [StringLength(50), MinLength(3)]
        public string Departure { get; set; }

        [StringLength(50), MinLength(3)]
        public string Destination { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public short? Seats { get; set; }

        //public virtual ICollection<Booking> BookingSet { get; set; }
    }
}
