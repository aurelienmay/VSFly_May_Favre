using FlightDecorator.component;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightDecorator.decorator
{
    class MealDecorator : ExtrasDecorator
    {
        protected static string DESCRIPTION = "meal";
        protected static int PRICE = 20;

        private component.FlightClass flight = null;
        private string flightClass;

        public MealDecorator(component.FlightClass flight)
        {
            this.flight = flight;
        }

        public MealDecorator(string flightClass)
        {
            this.flightClass = flightClass;
        }

        public override string getDescription()
        {
            return this.flight.getDescription() + ", " + DESCRIPTION;
        }

        public override int getCost()
        {
            return this.flight.getCost() + PRICE;
        }
    }
}
