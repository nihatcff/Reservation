namespace Reservation.ViewModels.ReservationViewModel
{
    public class CouponVm
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime ExpireDate { get; set; }
    }
}
