using Microsoft.AspNetCore.Mvc;

namespace OnlineFoodDeliveryPortal.Controllers
{
    [Route("restaurant")]
    public class ApiController : Controller
    {
        // Attribute Routing
        // /restaurant/details

        [Route("details")]
        public IActionResult Details()
        {
            ViewBag.Message = "Restaurant details loaded using Attribute Routing";

            return View();
        }
    }
}