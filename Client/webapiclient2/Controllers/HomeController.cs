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

            // Get the ticket price by flightNo
            data.TicketPrice = 120;

            return View(data);
        }

        public async Task<IActionResult> BookThisFlight(string txtName, int flightNo)
        {
            if (txtName == null)
            {
                //ViewBag.ErrorMessage = "invalid username";
                // Reload the page
                return RedirectToAction("FlightDetails", "Home", new { id = flightNo });
            }
            // Check the username

            // Get the id by username

            // DO THE POST ACTION in Bookset

            // -1 in available seats

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
