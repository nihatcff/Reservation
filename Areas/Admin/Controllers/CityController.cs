using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reservation.Models;
using Reservation.ViewModels.ReservationViewModel;
using System.Threading.Tasks;

namespace Reservation.Areas.Admin.Controllers;

[Area("Admin")]
public class CityController(AppDbContext _context) : Controller
{
    public async Task<IActionResult> Index()
    {
        var cities = await _context.Cities.ToListAsync();

        return View(cities);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CityVM vm)
    {
        if (!ModelState.IsValid)
        {
            return View(vm);
        }

        City city = new()
        {
            Name = vm.Name,
            CreatedDate = DateTime.Now,
        };


        await _context.Cities.AddAsync(city);
        await _context.SaveChangesAsync();  

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        var city = _context.Cities.FirstOrDefault(x => x.Id == id);
        if (city == null) return NotFound();

        _context.Cities.Remove(city);
        await _context.SaveChangesAsync();


        return RedirectToAction(nameof(Index));
    }
}
