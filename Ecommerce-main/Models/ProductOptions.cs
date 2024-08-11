using System.Text.Json.Serialization;

namespace Ecommerce.Models
{
    public class ProductOptions
    {
        public int Id { get; set; }
        public int ProductsId { get; set; }
        [JsonIgnore]
        public Products products { get; set; }
        public int OptionsId { get; set; }
        public Options options { get; set; }

    }
}
