using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Reservation.Models;

namespace Reservation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
