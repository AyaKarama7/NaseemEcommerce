namespace NaseemEcommerce.DTOs
{
    public class DisplayManyProductsDTO
    {
        public Guid Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public string Image { get; }
        public int Discount { get; }
        public bool IsActive { get; }
    }
}
