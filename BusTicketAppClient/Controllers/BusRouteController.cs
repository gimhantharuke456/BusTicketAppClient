using Microsoft.AspNetCore.Mvc;
using BusTickitAppClient.Models;
using System.Diagnostics;

namespace BusTicketAppClient.Controllers;

public class BusRouteController : Controller
{
    Uri baseUrl = new Uri("http://localhost:5017/api/BusRoute");
    private readonly HttpClient _client;

    public BusRouteController()
    {
        _client = new HttpClient();
        _client.BaseAddress = baseUrl;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var response = await _client.GetAsync(baseUrl);
        if (response.IsSuccessStatusCode)
        {
            var busRoutes = await response.Content.ReadFromJsonAsync<List<BusRoute>>();
            return View(busRoutes);
        }
        else
        {
            return View("Error");
        }

    }
}