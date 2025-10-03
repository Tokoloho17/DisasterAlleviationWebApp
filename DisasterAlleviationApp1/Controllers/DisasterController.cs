
using Microsoft.AspNetCore.Mvc;
using DisasterAlleviationApp1.Models;

namespace DisasterAlleviationApp1.Controllers
{
    public class DisasterController : Controller
    {
        public IActionResult Report()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Report(IncidentReport report)
        {
            ViewBag.Message = $"Incident reported at {report.Location}!";
            return View();
        }
    }
}
