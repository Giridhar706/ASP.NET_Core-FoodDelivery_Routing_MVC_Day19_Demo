using Microsoft.AspNetCore.Mvc;

namespace OnlineFoodDeliveryPortal.Controllers
{
    public class RestaurantController : Controller
    {
        // Default URL
        // /Restaurant/Menu
        public IActionResult Menu()
        {
            ViewBag.Message = "Welcome to Online Food Delivery Portal";

            List<string> foods = new List<string>()
            {
                "Burger",
                "Pizza",
                "Pasta",
                "Biryani",
                "Momos"
            };

            return View(foods);
        }

        // Route Constraint
        // Example: /restaurant/101
        public IActionResult Details(int id)
        {
            ViewBag.RestaurantId = id;

            return View();
        }
    }
}