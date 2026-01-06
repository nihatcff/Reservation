using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reservation.Models;
using Reservation.ViewModels.ReservationViewModel;

namespace Reservation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CouponController(AppDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var vm = await _context.Coupons.Select(x => new CouponVm
            {
                Id = x.Id,
                Title = x.CouponTitle,
                ExpireDate = x.ExpireDate
            }).ToListAsync();


            return View(vm);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(CouponVm vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            Coupon coupon = new()
            {
                CouponTitle = vm.Title,
                ExpireDate = vm.ExpireDate,
                CreatedDate = DateTime.Now
            };
            await _context.Coupons.AddAsync(coupon);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
