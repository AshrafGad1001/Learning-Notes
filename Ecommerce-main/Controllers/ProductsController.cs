using Ecommerce.DTOs;
using Ecommerce.Models;
using Ecommerce.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IRepo<Products> Prepo;
        private readonly IRepo<ProductOptions> Porepo;
        private readonly IRepo<Options> Orepo;
        private readonly ProductsAndOpitonsDTO dto;
        
        

        public ProductsController(IRepo<Products> Prepo, IRepo<ProductOptions> Porepo, IRepo<Options> Orepo, ProductsAndOpitonsDTO dto)
        {
            this.Prepo = Prepo;
            this.Porepo = Porepo;
            this.Orepo = Orepo;
            this.dto = dto;
        }
        [HttpGet("GetProductById")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await Prepo.GetById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }
        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(await Prepo.GetAll());
        }
        [HttpGet("GetProductByName")]
        public async Task<IActionResult> GetProductByName(string name)
        {
            var product = await Prepo.FindMatch(p => p.Name == name);
            if (product == null) return NotFound();
            return Ok(product);
        }
        [HttpGet("GetAllProductsByName")]
        public async Task<IActionResult> GetAllProductsByName(string name)
        {
            var product = await Prepo.FindAllMatch(p => p.Name == name);
            if (product == null) return NotFound();
            return Ok(product);
        }
        [HttpGet("GetAllProductsByPrice")]
        public async Task<IActionResult> GetAllProductsByName(int price)
        {
            var product = await Prepo.FindMatch(p => p.Price == price);
            if (product == null) return NotFound();
            return Ok(product);
        }
        [HttpGet("GetAllProductsAndProductsOptonsByName")]
        public async Task<IActionResult> GetAllProductsAndProductsOptonsByName(string name)//seepak
        {
            return Ok(await Prepo.FindAllMatchInclude(p => p.Name == name, new[] { "productOptions" } ));
        }
        [HttpGet("GetProductAndProductsOptonsByName")]
        public async Task<IActionResult> GetProductAndProductsOptonsByName(string name)
        {
            //return Ok(await Prepo.FindMatchInclude(p => p.Name == name, new[] { "productOptions" } ));
            //var pro = await Prepo.GetByName(name);
            //var ids=await Prepo.GetAll

            var product = await Prepo.FindMatch(p => p.Name == name);                    //product
            if (product == null) return NotFound();
            var Productoptions = await Porepo.FindAllMatch(po => po.ProductsId == product.Id);//ProductOptions
            if (Productoptions == null) return NotFound("Product don't have options");
            List<Options> options = new List<Options>(); //Options
            foreach (var item in Productoptions)
            {
                var x = await Orepo.GetById(item.OptionsId);
                options.Add(x);
            }
            foreach (var item in options)
            {
                dto.OptionsName.Add(item.Name);
            }

            dto.ProductId = product.Id;
            dto.Name = product.Name;
            dto.Price = product.Price;
            dto.Stock = product.Stock;
            dto.Image = product.Image;
            dto.Descriptions = product.Descriptions;
            
            return Ok(dto);
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromForm]PostProductDTO Pdto)
        {
            if (dto.Image == null) return BadRequest("Photo of product id requered");
            using var dataStream = new MemoryStream();
            await Pdto.Image.CopyToAsync(dataStream);
            Products products = new Products()
            {
                Name = Pdto.Name,
                Price = Pdto.Price,
                CreatedDate = Pdto.CreatedDate,
                Descriptions = Pdto.Descriptions,
                Stock = Pdto.Stock,
                Image = dataStream.ToArray()
            };
            await Prepo.Add(products);
            return Ok("Succeded add");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(int id,[FromForm]PostProductDTO dto)
        {
            var Product = await Prepo.GetById(id);
            if (Product == null) return NotFound();

            using var dataStream = new MemoryStream();
            await dto.Image.CopyToAsync(dataStream);

            Product.Name = dto.Name;
            Product.Price = dto.Price;
            Product.Stock = dto.Stock;
            Product.Descriptions = dto.Descriptions;
            Product.CreatedDate = dto.CreatedDate;
            Product.Image = dataStream.ToArray();
            Prepo.Update(Product);
            return Ok(Product);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(Products products)
        {
            if (products == null) return NotFound();
            Prepo.Delete(products);
            return Ok("Succeded Deleted");
        }

        //FindMatchInclude

    }
}
