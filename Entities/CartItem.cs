namespace E_Commerce_Outdoorways.Entities
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ProductIMG { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
