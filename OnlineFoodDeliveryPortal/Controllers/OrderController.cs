using Microsoft.AspNetCore.Mvc;

namespace OnlineFoodDeliveryPortal.Controllers
{
    public class OrderController : Controller
    {
        // Custom Route
        // /order-food

        [HttpGet]
        public IActionResult PlaceOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PlaceOrder(string customerName, string foodItem, int quantity)
        {
            ViewBag.CustomerName = customerName;
            ViewBag.FoodItem = foodItem;
            ViewBag.Quantity = quantity;

            return View("OrderSuccess");
        }
    }
}