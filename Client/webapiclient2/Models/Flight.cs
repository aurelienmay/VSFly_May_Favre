using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webapiclient2.Models
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

        public short? AvailableSeats { get; set; }

        [Required]
        public short? Seats { get; set; }

        [Required]
        public float BasePrice { get; set; }

        //[ForeignKey("PilotId")]
        //public virtual Pilot Pilot { get; set; }
        //public int PilotId { get; set; }

        public virtual ICollection<Booking> BookingSet { get; set; }
    }
}
