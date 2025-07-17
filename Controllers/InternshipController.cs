using Microsoft.AspNetCore.Mvc;

namespace kgetechnologies.Controllers
{
    public class InternshipController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Location(string technology, string location)
        {
            ViewBag.Technology = technology;    
            ViewBag.Location = location;
            return View();
        }
    }
}
