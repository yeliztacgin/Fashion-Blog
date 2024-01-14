using Microsoft.AspNetCore.Mvc;

namespace BlogFashion.Controllers
{
    public class TrendController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
