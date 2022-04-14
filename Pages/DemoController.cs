using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Pages
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
