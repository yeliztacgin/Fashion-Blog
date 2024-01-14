using Microsoft.AspNetCore.Mvc;

namespace BlogFashion.Controllers
{
    public class FashionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
