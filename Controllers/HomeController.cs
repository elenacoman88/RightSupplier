using Microsoft.AspNetCore.Mvc;

namespace RightSupplier.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Render the home page.
        }

        public IActionResult About()
        {
            return View(); // Render the about page.
        }

        public IActionResult HowItWorks()
        {
            return View(); // Render the how it works page.
        }
    }
}