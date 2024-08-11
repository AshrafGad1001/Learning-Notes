using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Ecommerce.Models
{
    public class Categories
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public List<ProductCategories> productCategories { get; set; } = new List<ProductCategories>();

    }
}
