using Microsoft.AspNetCore.Mvc;
using AdvancedRoutingMVC.Models;

namespace AdvancedRoutingMVC.Controllers
{
    public class ProductsController : Controller
    {
        [Route("Products/{category}/{id:guidcheck}")]
        public IActionResult Details(string category, Guid id)
        {
            Product product = new Product
            {
                Category = category,
                Id = id,
                ProductName = "Wireless Headphones",
                Price = 2999
            };

            return View(product);
        }

        [Route("Products/Filter/{category}")]
        public IActionResult Filter(string category)
        {
            ViewBag.Category = category;

            return View();
        }
    }
}