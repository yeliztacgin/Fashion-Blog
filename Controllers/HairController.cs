using Microsoft.AspNetCore.Mvc;

namespace BlogFashion.Controllers
{
    public class HairController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
