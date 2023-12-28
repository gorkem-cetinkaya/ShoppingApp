using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string NameSurname { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        public string Email { get; set; }
    }
}