using System;
using System.Collections.Generic;
using System.Text;

namespace FlightDecorator.component
{
    class FlightFirstClass : FlightClass
    {
        protected static int PRICE = 100;
        protected static string DESCRIPTION = "First class";

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
