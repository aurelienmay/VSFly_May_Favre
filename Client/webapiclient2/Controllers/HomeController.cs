using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FlightDecorator.component;
using FlightDecorator.decorator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

            List<SelectListItem> ObjList = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Second", Value = "1" },
                new SelectListItem { Text = "Business", Value = "2" },
                new SelectListItem { Text = "First", Value = "3" },
            };
            //Assigning generic list to ViewBag
            ViewBag.Locations = ObjList;

            return View(data);
        }

        public async Task<IActionResult> FlyDetails(int extraPrice, string description, float ticketPrice, string user)
        {
            TicketDetails details = new TicketDetails();
            details.Description = description;
            details.price = ticketPrice;
            details.extraPrice = extraPrice;
            details.username = user;
            details.totalPrice = ticketPrice + extraPrice;

            return View(details);
        }

        public async Task<IActionResult> BookThisFlight(string username, int flightNo, float basePrice, int ObjList, bool luggage, bool meal, bool tv)
        {
            // DECORATOR
            FlightClass fly = new FlightBusinessClass();
            switch (ObjList)
            {
                case 3:
                    fly = new FlightFirstClass();
                    break;

                case 2:
                    fly = new FlightBusinessClass();
                    break;

                case 1:
                    fly = new FlightSecondClass();
                    break;
            }

            if (luggage)
            {
                fly = new LuggageDecorator(fly);
            }

            if (meal)
            {
                fly = new MealDecorator(fly);
            }

            if (tv)
            {
                fly = new TVDecorator(fly);
            }

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

            // DO THE PUT ACTION IN FLIGHT (-1 in available seats)
            Flight flight = await ApiClientFactory.Instance.GetFlight(flightNo);
            await ApiClientFactory.Instance.PutFlight(flightNo, flight);

            return RedirectToAction("FlyDetails", "Home", new { extraPrice = fly.getCost(), description = fly.getDescription(), ticketPrice = basePrice, user = username });
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
