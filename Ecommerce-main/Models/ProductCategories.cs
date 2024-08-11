using System.Text.Json.Serialization;

namespace Ecommerce.Models
{
    public class ProductCategories
    {
        public int Id { get; set; }
        public int ProductsId { get; set; }
        [JsonIgnore]
        public Products products { get; set; }
        public int CategoriesId { get; set; }
        public Categories categories { get; set; }
    }
}
