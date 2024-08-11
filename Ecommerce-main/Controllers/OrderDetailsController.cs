using Ecommerce.DTOs;
using Ecommerce.Models;
using Ecommerce.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IRepo<OrderDetails> Drepo;
        private readonly IRepo<Products> Prepo;
        private readonly IRepo<Orders> Orepo;
        private readonly IRepo<ProductOptions> Porepo;
        private readonly IRepo<Options> Otirepo;
        private readonly ProductDetailsDTO dto;

        public OrderDetailsController(IRepo<Orders> Orepo,ProductDetailsDTO dto,IRepo<OrderDetails> Drepo, IRepo<Products> Prepo, IRepo<ProductOptions> Porepo)
        {
            this.Drepo = Drepo;
            this.Prepo = Prepo;
            this.Porepo = Porepo;
            this.dto = dto;
            this.Orepo = Orepo;
        }
        [HttpGet("GetProductDetailsById")]//customer
        public async Task<IActionResult> GetProductDetailsById(int id)
        {
            var ProductDetails = await Drepo.GetById(id);
            if (ProductDetails == null) return NotFound();
            var Product = await Prepo.GetById(ProductDetails.ProductsId);
            if(Product==null) return NotFound($"Not found product with id:{id}");
            dto.Id = Product.Id;
            dto.Name = Product.Name;
            dto.Price = Product.Price;
            dto.CreatedDate = Product.CreatedDate;
            dto.Stock = Product.Stock;
            dto.Descriptions = Product.Descriptions;
            dto.Image = Product.Image;
            
            return Ok(dto);
        }
        [HttpGet("GetOrderDetailsById")]//seller
        public async Task<IActionResult> GetOrderDetailsById(int id)
        {
            var Oreder = await Orepo.GetById(id);
            if (Oreder==null) return NotFound();
            return Ok(Oreder);
        }
       
    }
}
