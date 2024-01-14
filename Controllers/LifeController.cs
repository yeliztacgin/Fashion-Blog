using Microsoft.AspNetCore.Mvc;

namespace BlogFashion.Controllers
{
    public class LifeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
