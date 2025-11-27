using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Outdoorways.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; } // Foreign Key Reference to User
        public decimal TotalAmount { get; set; }
        public User? User { get; set; } = null; // Navigation Property: is an object that lets EF create the
                                                // constraint and gets the foreign key reference from another
                                                // table automatically.
        public ICollection<OrderItem> OrderItems { get; set; } 
    }
}
