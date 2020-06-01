using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapiclient2.Models
{
    public class TicketDetails
    {
        public string username { get; set; }

        public string Description { get; set; }

        public float price { get; set; }

        public int extraPrice { get; set; }

        public float totalPrice { get; set; }
    }
}
