using Microsoft.AspNetCore.Mvc;
using DisasterAlleviationApp1.Models;

namespace DisasterAlleviationApp1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            ViewBag.Message = $"User {user.FullName} registered successfully!";
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (!string.IsNullOrEmpty(user.FullName) && !string.IsNullOrEmpty(user.Password))
            {
                ViewBag.Message = $"Welcome, {user.FullName}!";
            }
            else
            {
                ViewBag.Message = "Invalid login!";
            }
            return View();
        }
    }
}
