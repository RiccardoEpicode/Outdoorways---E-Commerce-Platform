using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Outdoorways.Entities
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Type { get; set; }
        public ICollection<Order> Orders { get; set; } 
    }
}
