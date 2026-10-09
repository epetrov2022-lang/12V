using System.ComponentModel.DataAnnotations;

namespace TravelAgency
{
    public class Bookings
    {
        public int Id { get; set; }

        [Required]

        public int BookingDate; DateTime DateTime { get; set; }


        [Required]

       public string CustomerID { get; set; }

        [Required]

        public string TourPackageId { get; set; }







    }
}
