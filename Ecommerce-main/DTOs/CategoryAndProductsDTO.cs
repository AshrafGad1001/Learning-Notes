using System.ComponentModel.DataAnnotations;

namespace Ecommerce.DTOs
{
    public class CategoryAndProductsDTO
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<ProductListCategory> productListCategories { get; set; } = new List<ProductListCategory>();
    }
}
