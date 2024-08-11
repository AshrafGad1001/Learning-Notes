using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Ecommerce.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int ammount { get; set; }
        [MaxLength(200)]
        public string ShippingAddress { get; set; }
        [MaxLength(100)]
        public string DistinctiveBuilding { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime OrderDate { get; set; }
        [JsonIgnore]

        public List<OrderDetails> orderDetails { get; set; } = new List<OrderDetails>();



    }
}
