using Ecommerce.Models;
using Ecommerce.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IRepo<Orders> Orepo;

        public OrdersController(IRepo<Orders> Orepo)
        {
            this.Orepo = Orepo;
        }
        [HttpPost("AddOrder")]//customer
        public async Task<IActionResult> AddOrder(Orders orders)
        {
            await Orepo.Add(orders);
            return Ok("Suceeded Add");
        }
    }
}
