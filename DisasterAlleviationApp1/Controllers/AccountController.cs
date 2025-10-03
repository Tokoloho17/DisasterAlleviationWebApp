using DisasterAlleviationApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DisasterAlleviationApp1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Could be a profile or user list
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            // Later: save to database
            ViewBag.Message = "User registered successfully!";
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            // Later: check authentication
            ViewBag.Message = "Login attempt for " + user.Email;
            return View();
        }
    }
}
