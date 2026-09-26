using Microsoft.AspNetCore.Mvc;

namespace PizzaDemo.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
