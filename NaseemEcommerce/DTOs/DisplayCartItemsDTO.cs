namespace NaseemEcommerce.DTOs
{
    public class DisplayCartItemsDTO
    {
        public Guid CartId { get; }
        public Guid ProductId { get; }
        public string ProductName { get; }
        public decimal Price { get; }
        public int Discount { get; }
        public string Image { get; }
        public int Quantity { get; }

    }
}
