using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Outdoorways.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
