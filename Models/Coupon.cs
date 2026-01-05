using System.ComponentModel.DataAnnotations;

namespace Reservation.Models
{
    public class Coupon:BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime ExpireDate { get; set; }
        [MaxLength(12)]
        [Required]
        public string CouponTitle { get; set; }=string.Empty;
    }
}
