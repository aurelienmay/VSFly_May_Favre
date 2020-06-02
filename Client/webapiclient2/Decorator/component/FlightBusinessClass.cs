using System;
using System.Collections.Generic;
using System.Text;

namespace FlightDecorator.component
{
    class FlightBusinessClass : FlightClass
    {
        protected static int PRICE = 50;
        protected static string DESCRIPTION = "You will be in Business class";

        public override string getDescription()
        {
            return DESCRIPTION;
        }

        public override int getCost()
        {
            return PRICE;
        }
    }
}
