using FlightDecorator.component;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightDecorator.decorator
{
    class LuggageDecorator : ExtrasDecorator
    {
        protected static string DESCRIPTION = "luggage";
        protected static int PRICE = 40;

        private component.FlightClass flight = null;

        public LuggageDecorator(component.FlightClass flight)
        {
            this.flight = flight;
        }

        public override int getCost()
        {
            return this.flight.getCost() + PRICE;
        }

        public override string getDescription()
        {
            return this.flight.getDescription() + ", " + DESCRIPTION;
        }
    }
}
