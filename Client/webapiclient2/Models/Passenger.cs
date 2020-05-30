using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webapiclient2.Models
{
    public class Passenger
    {
        public Passenger() { }

        [Key]
        public int PassengerID { get; set; }

        public string Username { get; set; }
    }
}
