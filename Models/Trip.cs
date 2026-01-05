using System.ComponentModel.DataAnnotations;

namespace Reservation.Models
{
    public class Trip: BaseEntity
    {
        [Required]
        [MaxLength(64)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [MaxLength(64)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [MaxLength(64)]
        public string Email { get; set; } = string.Empty;
        public int CityId { get; set; }
        public City? City { get; set; }
        public bool isBoarding { get; set; }
        public bool isFooding { get; set; }
        public bool isSightseeing { get; set; }
        public int? CouponId { get; set; }
        public Coupon? Coupon { get; set; }
        public bool isTermsAccepted { get; set; }
    }
}
