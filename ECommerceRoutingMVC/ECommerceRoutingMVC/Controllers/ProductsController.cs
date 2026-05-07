using Microsoft.AspNetCore.Mvc;
using ECommerceRoutingMVC.Models;

namespace ECommerceRoutingMVC.Controllers
{
    public class ProductsController : Controller
    {
        [Route("Products/{category:categorycheck}/{id}")]
        public IActionResult Details(
            string category,
            int id)
        {
            Product product = new Product
            {
                Id = id,
                Category = category,
                Name = "Smart Watch",
                Price = 4999
            };

            return View(product);
        }

        [Route("Products/Filter/{category:categorycheck}/{priceRange}")]
        public IActionResult Filter(
            string category,
            string priceRange)
        {
            ViewBag.Category = category;
            ViewBag.PriceRange = priceRange;

            return View();
        }
    }
}