using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class StoringController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
