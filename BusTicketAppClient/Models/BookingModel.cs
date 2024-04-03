namespace BusTickitAppClient.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int NumOfSeats { get; set; }
        public int RouteId { get; set; }
        public DateTime BookingTime { get; set; }
    }
}
