using Microsoft.AspNetCore.Mvc;

namespace Reservation.Areas.Admin.Controllers
{
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
