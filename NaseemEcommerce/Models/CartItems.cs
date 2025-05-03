namespace NaseemEcommerce.Models
{
    public class CartItems
    {
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public Cart Cart { get; set; }
        public Product Product { get; set; }
    }
}
