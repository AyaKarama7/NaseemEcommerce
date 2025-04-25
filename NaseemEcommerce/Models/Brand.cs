namespace NaseemEcommerce.Models
{
    public class Brand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public List<Product> Products { get; set; }
    }
}
