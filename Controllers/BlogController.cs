// BlogController.cs

using Microsoft.AspNetCore.Mvc;

namespace RightSupplier.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            // Logic to fetch and display blog posts
            return View();
        }

        public IActionResult Details(int id)
        {
            // Logic to fetch and display a specific blog post by id
            return View();
        }

        // Additional actions related to blog pages can be added here.
    }
}