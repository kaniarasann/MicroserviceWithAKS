
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppingApp.Model;
using System.Text.Json.Serialization;

namespace ShoppingApp.Controllers
{
    public class HomeController : Controller
    {
        public readonly IHttpClientFactory _httpClient;
        public HomeController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var res = _httpClient.CreateClient("ShoppingAPIClinet");
                var data = await res.GetAsync("api/Product/GetAllProduct");
                var content=await data.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<IEnumerable<Product>>(content);
                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
