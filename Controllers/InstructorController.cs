using Microsoft.AspNetCore.Mvc;
using Dziekanat.Models;
using Dziekanat.Data;
using System.Linq;

namespace Dziekanat.Controllers
{
    public class InstructorController : Controller
    {
        private readonly AppDbContext _context;
        public InstructorController(AppDbContext context) {
            _context = context; 
        }
        public IActionResult Index()
        {
            var instructors = _context.users.ToList();
            return View(instructors);
        }

        
        public IActionResult Create()
        {
            return View();
        }

     
    }
}
