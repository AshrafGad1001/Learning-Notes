namespace Ecommerce.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int ProductsId { get; set; }
        public Products products { get; set; }
        public int OrdersId { get; set; }
        public Orders orders { get; set; }

    }
}
