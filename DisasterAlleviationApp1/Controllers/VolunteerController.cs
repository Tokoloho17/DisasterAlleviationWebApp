using DisasterAlleviationApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DisasterAlleviationApp1.Controllers
{
    public class VolunteerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Volunteer volunteer)
        {
            ViewBag.Message = $"Volunteer {volunteer.Name} registered successfully!";
            return View();
        }

        public IActionResult Tasks()
        {
            return View(); // later: show volunteer tasks
        }
    }
}
