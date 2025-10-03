using DisasterAlleviationApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DisasterAlleviationApp1.Controllers
{
    public class DonationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Donation donation)
        {
            ViewBag.Message = $"Donation from {donation.DonorName} added successfully!";
            return View();
        }

        public IActionResult List()
        {
            return View(); // later: show donations from DB
        }
    }
}
