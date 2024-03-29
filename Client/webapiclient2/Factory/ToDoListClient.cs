﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiclient2.Models;

namespace webapiclient2
{
    public partial class ApiClient
    {
        public async Task<List<Flight>> GetFlights()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Flights/"));
            return await GetAsync<List<Flight>>(requestUrl);
        }

        public async Task<Flight> GetFlight(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Flights/" + id));
            return await GetAsync<Flight>(requestUrl);
        }

        public async Task<int> GetPassengerUID(string username)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Passenger/" + username));
            return await GetAsync<int>(requestUrl);
        }

        public async Task<Message<Booking>> SaveBooking(Booking booking)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Booking/"));
            return await PostAsync<Booking>(requestUrl, booking);
        }

        public async Task<Message<Flight>> PutFlight(int id, Flight flight)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Flights/" + id));
            return await PutAsync<Flight>(requestUrl, flight);
        }
    }
}
