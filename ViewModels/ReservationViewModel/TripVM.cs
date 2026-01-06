using Reservation.Models;
using System.ComponentModel.DataAnnotations;

namespace Reservation.ViewModels.ReservationViewModel
{
    public class TripVM
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int CityId { get; set; }
        public List<City> Cities { get; set; } = new List<City>();
        public bool isBoarding { get; set; }
        public bool isFooding { get; set; }
        public bool isSightseeing { get; set; }
        public int? CouponId { get; set; }
        public bool isTermsAccepted { get; set; }
    }
}
