using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiclient2.Models;

namespace webapiclient2
{
    public partial class ApiClient
    {
        public async Task<List<TodoItem>> GetTodoItems()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "TodoItems/"));
            return await GetAsync<List<TodoItem>>(requestUrl);
        }

        public async Task<List<Flight>> GetFlights()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Flights/"));
            return await GetAsync<List<Flight>>(requestUrl);
        }

        public async Task<FlightBooking> GetFlight(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Flights/" + id));
            return await GetAsync<FlightBooking>(requestUrl);
        }

        public async Task<Message<TodoItem>> SaveTodoItem(TodoItem model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "TodoItems/"));
            return await PostAsync<TodoItem>(requestUrl, model);
        }
    }
}
