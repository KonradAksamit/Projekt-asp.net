using Microsoft.AspNetCore.Mvc;

namespace Dziekanat.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
