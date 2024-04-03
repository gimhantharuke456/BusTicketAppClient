using Microsoft.AspNetCore.Mvc;
using BusTickitAppClient.Models;
using System.Diagnostics;

namespace BusTicketAppClient.Controllers;

public class BookingsController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}