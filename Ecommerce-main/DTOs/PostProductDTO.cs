using System.ComponentModel.DataAnnotations;

namespace Ecommerce.DTOs
{
    public class PostProductDTO
    {
        public string Name { get; set; }
        public double Price { get; set; }
        [MaxLength(200)]
        public string Descriptions { get; set; }
        public IFormFile Image { get; set; }
        public int Stock { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
