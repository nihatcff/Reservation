

using System.ComponentModel.DataAnnotations;

namespace Reservation.Models
{
    public class City : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public ICollection<Trip>? Reservations { get; set; } = new List<Trip>();
    }
}
