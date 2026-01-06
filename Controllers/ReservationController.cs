using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reservation.Models;
using Reservation.ViewModels.ReservationViewModel;

namespace Reservation.Controllers
{
    public class ReservationController : Controller
    {
        private readonly AppDbContext _context;

        public ReservationController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reservation
        public async Task<IActionResult> Index()
        {
            ViewBag.Cities = await _context.Cities.ToListAsync();
            return View(new TripVM());
        }

        // POST: Reservation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TripVM VM)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Cities = await _context.Cities.ToListAsync();
                return View("Index", VM);
            }

            var trip = new Trip
            {
                FirstName = VM.FirstName,
                LastName = VM.LastName,
                Email = VM.Email,
                CityId = VM.CityId,
                isBoarding = VM.isBoarding,
                isFooding = VM.isFooding,
                isSightseeing = VM.isSightseeing,
                CouponId = VM.CouponId,
                isTermsAccepted = VM.isTermsAccepted
            };

            await _context.Trips.AddAsync(trip);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Success));
        }

        // GET: Reservation/Success
        public IActionResult Success()
        {
            return View();
        }
    }
}
