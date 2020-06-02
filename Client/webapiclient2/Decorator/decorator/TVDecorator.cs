using FlightDecorator.component;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightDecorator.decorator
{
    class TVDecorator : ExtrasDecorator
    {
        protected static string DESCRIPTION = "tv";
        protected static int PRICE = 10;

        private component.FlightClass flight = null;

        public TVDecorator(component.FlightClass flight)
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
