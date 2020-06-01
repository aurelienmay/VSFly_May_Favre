using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using webapiclient2.Factory;
using webapiclient2.Models;
using webapiclient2.Utility;

namespace webapiclient2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptions<MySettingsModel> appSettings;

        public HomeController(ILogger<HomeController> logger, IOptions<MySettingsModel> app)
        {
            appSettings = app;
            ApplicationSettings.WebApiUrl = appSettings.Value.WebApiBaseUrl;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var data = await ApiClientFactory.Instance.GetFlights();
            return View(data);
        }

        public async Task<IActionResult> FlightDetails(int id)
        {
            var data = await ApiClientFactory.Instance.GetFlight(id);

            // Get the username error message (if booked with wrong username)
            ViewBag.ErrorMessage = Convert.ToString(TempData["invalidUsername"]);

            //data.TicketPrice = 120;

            return View(data);
        }

        public async Task<IActionResult> BookThisFlight(string username, int flightNo, float basePrice)
        {
            // Check username validity
            if (username == null) 
            {
                // Reload the page with an error
                TempData["invalidUsername"] = "invalidUsername";
                return RedirectToAction("FlightDetails", "Home", new { id = flightNo });
            }

            // Get the passengerID by username
            int passengerID = await ApiClientFactory.Instance.GetPassengerUID(username);

            // Check the username validity
            if (passengerID == 0)
            {
                // Reload the page with an error
                TempData["invalidUsername"] = "invalidUsername";
                return RedirectToAction("FlightDetails", "Home", new { id = flightNo });
            }

            // DO THE POST ACTION in Booking
            Booking booking = new Booking();
            booking.FlightNo = flightNo;
            booking.PassengerID = passengerID;
            booking.TicketPrice = basePrice;

            await ApiClientFactory.Instance.SaveBooking(booking);

            // -1 in available seats
            Flight flight = await ApiClientFactory.Instance.GetFlight(flightNo);
            flight.AvailableSeats--;
            await ApiClientFactory.Instance.PutFlight(flightNo, flight);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
