using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Ecommerce.Models
{
    public class Options
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
       // [JsonIgnore]

        public List<ProductOptions> productOptions { get; set; } = new List<ProductOptions>();
    }
}
