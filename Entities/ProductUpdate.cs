using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Outdoorways.Entities
{
    public class ProductUpdate
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDesc { get; set; }
        public decimal Price { get; set; }
        public int ProductQty { get; set; }
        public string? ProductIMG { get; set; } = null; // Initally they don't have an image so we set it to null
                                                        // and the type followed by ?
        public Category? Category { get; set; }
    }
}
