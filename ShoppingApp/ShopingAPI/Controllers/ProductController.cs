using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using ShopingAPI.Data;
using ShopingAPI.Model;

namespace ShopingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductContext _context;
        public ProductController(ProductContext context) { 
        _context = context;
        }  

        [HttpGet]
        [Route("GetAllProduct")]
        public async Task<IActionResult> GetAllProduct()
        {
            var filter = Builders<Product>.Filter.Empty;
            var result  = await _context.products.Find(filter).ToListAsync();
            return Ok(result);
        }
    }
}
