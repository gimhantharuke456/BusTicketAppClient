using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BusTickitAppClient.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketAppClient.Controllers
{

    public class SignupController : Controller
    {
        Uri baseUrl = new Uri("http://localhost:5017/api/User");
        private readonly HttpClient _client;

        public SignupController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseUrl;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(User model)
        {



            HttpResponseMessage response = await _client.PostAsJsonAsync(baseUrl, model);

            Debug.WriteLine("================ " + response.StatusCode);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Error", model);
            }
        }
    }
}
