using Microsoft.AspNetCore.Mvc;

namespace khumaloCrafts.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
