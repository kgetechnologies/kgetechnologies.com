using System.Diagnostics;
using kgetechnologies.Models;
using Microsoft.AspNetCore.Mvc;

namespace kgetechnologies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //TODO: Pages to add
        //https://techguru-laravel.scriptfusions.com/about
        //https://techguru-laravel.scriptfusions.com/portfolio
        //https://techguru-laravel.scriptfusions.com/portfolio-details
        //https://techguru-laravel.scriptfusions.com/faq
        //https://techguru-laravel.scriptfusions.com/404
        //https://techguru-laravel.scriptfusions.com/services
        //https://techguru-laravel.scriptfusions.com/services-carousel
        //https://techguru-laravel.scriptfusions.com/advanced-technology
        //https://techguru-laravel.scriptfusions.com/product-details
        //https://techguru-laravel.scriptfusions.com/contact
        //https://techguru-laravel.scriptfusions.com/pricing




    }
}
