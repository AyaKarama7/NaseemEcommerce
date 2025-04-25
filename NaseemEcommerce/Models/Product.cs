namespace NaseemEcommerce.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Stock { get; set; }
        public int Discount { get; set; }
        public bool IsActive { get; set; }
        public string Category { get; set; }
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
