namespace NaseemEcommerce.DTOs
{
    public class DisplayOneProductDTO
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string Brand { get; }
        public decimal Price { get; }
        public string Image { get; }
        public int Discount { get; }
        public bool IsActive { get; }
        public string Category { get; }
    }
}
