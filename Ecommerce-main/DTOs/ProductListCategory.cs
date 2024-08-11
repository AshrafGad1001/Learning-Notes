using Ecommerce.Models;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.DTOs
{
    public class ProductListCategory
    {       
        public ProductListCategory(Products products )
        {
            

            this.ProductName = products.Name;
            this.ProductDescriptions = products.Descriptions;
            this.Price = products.Price;
            this.Stock = products.Stock;
            this.CreatedDate = products.CreatedDate;
            this.Image = Image;
        }
        public string ProductName { get; set; }
        public double Price { get; set; }
        [MaxLength(200)]
        public string ProductDescriptions { get; set; }
        public byte[] Image { get; set; }
        public int Stock { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
