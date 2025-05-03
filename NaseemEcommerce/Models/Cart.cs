namespace NaseemEcommerce.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public List<CartItems> CartItems { get; set; }
    }
}
