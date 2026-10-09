using System.ComponentModel.DataAnnotations;

namespace TravelAgency
{
    public class Customers
    {

        public int id { get; set; }
        [Required]

        public string FullName { get; set; }
        [Required]
        [MaxLength(60)]

        public string Email { get; set; }
        [Required]

        public int PhoneNumber { get; set; }
        






    } 
}
