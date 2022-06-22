using Barbershop_Booking_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Barbershop_Booking_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        public ViewResult Register()
        {
            return View();
        }

        public ViewResult Services()
        {
            return View();
        }

        public ViewResult About()
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