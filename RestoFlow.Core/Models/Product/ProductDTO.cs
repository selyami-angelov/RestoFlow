
namespace RestoFlow.Core.Models.Product
{
    public class ProductDTO
    {
        public int? Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public string Img { get; set; } = null!;
    }
}
