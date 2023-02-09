using Microsoft.AspNetCore.Mvc;

namespace Dziekanat.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
