using System.ComponentModel.DataAnnotations;

namespace TravelAgency
{
    public class Guides
    {
        public int Id { get; set; }

        [Required]

        public string FullName { get; set; }

        public string Language { get; set; }



    }
}
