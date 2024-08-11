using Ecommerce.DTOs;
using Ecommerce.Models;
using Ecommerce.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IRepo<Categories> Crepo;
        private readonly IRepo<ProductCategories> Pcrepo;
        private readonly IRepo<Products> Prepo;
        private readonly CategoryAndProductsDTO dto; 
        public CategoriesController(IRepo<Categories> Crepo, IRepo<ProductCategories> Pcrepo, IRepo<Products> Prepo, CategoryAndProductsDTO dto)
        {
            this.Crepo = Crepo;
            this.Prepo = Prepo;
            this.Pcrepo = Pcrepo;
            this.dto = dto;
        }
        [HttpGet("GetAllCategories")]
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(await Crepo.GetAll());
        }
        [HttpGet("GetCategoryAndProductsById")]
        public async Task<IActionResult> GetCategoryAndProductsById(int id)
        {
            var Category =await Crepo.GetById(id);
            if (Category == null) return NotFound();
            var ProductsCategory = await Pcrepo.FindAllMatch(p => p.CategoriesId == id);
            if (ProductsCategory == null) return NotFound("Category don't have Products");
            dto.CategoryName = Category.Name;
            dto.CategoryDescription = Category.Description;
            foreach (var item in ProductsCategory)
            {
                var Product =await Prepo.GetById(item.ProductsId);
                dto.productListCategories.Add(new ProductListCategory(Product));
            }
            return Ok(dto);
        }
        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory(Categories categories)
        {
            if (categories == null) return BadRequest();
            await Crepo.Add(categories);
            return Ok("Succeeded Add");
        }
        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory(Categories categories)
        {
            if (categories == null) return BadRequest();
            await Crepo.Update(categories);
            return Ok("Succeeded Update");
        }
        [HttpDelete("Delete Category")]
        public async Task<IActionResult> DeleteCategory(Categories categories)
        {
            if (categories == null) return NotFound();
            Crepo.Delete(categories);
            return Ok("Succeeded Delete");
        }

    }
}
