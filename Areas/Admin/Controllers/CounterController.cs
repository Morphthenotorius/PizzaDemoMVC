using Microsoft.AspNetCore.Mvc;
using PizzaDemo.Data;

namespace PizzaDemo.Areas.Admin.Controllers
{
    public class CounterController : Controller
    {
        private readonly AppDbContext _context;

        public CounterController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
