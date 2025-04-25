namespace NaseemEcommerce.DTOs
{
    public class DisplayOneProductDTO
    {
        public Guid Id;
        public string Name;
        public string Description { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Discount { get; set; }
        public bool IsActive { get; set; }
        public string Category { get; set; }
    }
}
