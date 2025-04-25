namespace NaseemEcommerce.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public decimal TotalPrice { get; set; }
        public string ShippingAddress { get; set; }
        public string Status { get; set; }
    }
}
