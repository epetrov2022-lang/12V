using System.ComponentModel.DataAnnotations;

namespace TravelAgency
{
    public class TourPackagesGuides
    {
        [Required]
        public int TourPackageId { get; set; }

        [Required]

        public int GuideId {  get; set; }




    }
}
