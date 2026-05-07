using Microsoft.AspNetCore.Mvc;

namespace ECommerceRoutingMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}