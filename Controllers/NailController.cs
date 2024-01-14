using Microsoft.AspNetCore.Mvc;

namespace BlogFashion.Controllers
{
    public class NailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
