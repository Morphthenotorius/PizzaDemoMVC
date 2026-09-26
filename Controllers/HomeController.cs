using Microsoft.AspNetCore.Mvc;
using PizzaDemo.Data;
using PizzaDemo.Models;
using System.Diagnostics;

namespace PizzaDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel()
            {
                Pizzas = _context.Pizzas.ToList(),
                Services = _context.Services.ToList(),
                Blogs = _context.Blogs.ToList(),
                BlogHeaders= _context.BlogsHeader.ToList(),
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
