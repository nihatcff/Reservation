using Microsoft.EntityFrameworkCore;
using Reservation.Models;

namespace Reservation.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions option):base(option)
        {
            
        }

        public DbSet<City> Cities { get; set; } 
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Coupon> Coupons { get; set; }

    }
}
