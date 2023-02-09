using Microsoft.AspNetCore.Mvc;

namespace Dziekanat.Controllers
{
    public class EnrollmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
