using System.ComponentModel.DataAnnotations;

namespace Ecommerce.DTOs
{
    public class ProductsAndOpitonsDTO
    {
        public int ProductId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public double Price { get; set; }
        [MaxLength(200)]
        public string Descriptions { get; set; }
        public byte[] Image { get; set; }
        public int Stock { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<string> OptionsName { get; set; } = new List<string>();
    }
}
