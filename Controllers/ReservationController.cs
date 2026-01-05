using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reservation.Models;
using Reservation.ViewModels.ReservationViewModel;

namespace Reservation.Controllers
{
    public class ReservationController(AppDbContext _context):Controller
    {
        public async Task<IActionResult> Index()
        {
            ViewBag.Cities = await _context.Cities.ToListAsync();
            var TripVM = new TripVM();
            return View(TripVM);
        }


        [HttpPost]
        public async Task<IActionResult> Create(TripVM VM)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            await _context.Trips.AddAsync(new Trip
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
            });

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
