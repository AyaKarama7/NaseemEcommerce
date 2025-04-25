namespace NaseemEcommerce.Models
{
    public class Review
    {
        public Guid Id { get; set; }
        public int Rate { get; set; }
        public string? Comment { get; set; }
        public DateOnly Date { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

    }
}
