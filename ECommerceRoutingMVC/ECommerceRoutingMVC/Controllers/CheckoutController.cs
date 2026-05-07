using Microsoft.AspNetCore.Mvc;

namespace ECommerceRoutingMVC.Controllers
{
    public class CheckoutController : Controller
    {
        [Route("Checkout")]
        public IActionResult Index(
            bool isLoggedIn = false)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction(
                    "Login",
                    "Account");
            }

            return View();
        }
    }
}
