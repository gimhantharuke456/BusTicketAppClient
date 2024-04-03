namespace BusTickitAppClient.Models
{

    public class BusRoute
    {

        public int RouteId { get; set; }



        public string? Origin { get; set; }


        public string? Destination { get; set; }


        public DateTime DepartureTime { get; set; }


        public DateTime ArrivalTime { get; set; }

        public int? BusId { get; set; }

        public Bus? Bus { get; set; }
    }
}
