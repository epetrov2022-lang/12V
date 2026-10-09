using System.ComponentModel.DataAnnotations;

namespace TravelAgency
{
    public class TourPackages
    {

        public int Id { get; set; }

        [Required]

        public string PackageName { get; set; } 

        public string Description { get; set; }

        [Required]


        public decimal Price { get; set; }









    }
}
