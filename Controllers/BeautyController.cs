using Microsoft.AspNetCore.Mvc;

namespace BlogFashion.Controllers
{
    public class BeautyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
