namespace NaseemEcommerce.DTOs
{
    public class DisplayManyProductsDTO
    {
        public Guid Id;
        public string Name;
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Discount { get; set; }
        public bool IsActive { get; set; }
    }
}
