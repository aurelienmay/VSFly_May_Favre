using System;
using System.Collections.Generic;
using System.Text;

namespace FlightDecorator.component
{
    class FlightSecondClass : FlightClass
    {
        protected static int PRICE = 0;
        protected static string DESCRIPTION = "Second class";

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
