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
        //visit https://github.com/Akash17112004/kgenew and donwload as zip under Code green button.
        //moved all images and fonts to CDN path --> https://github.com/kgetechnologies/kgesitecdn/tree/kge2025Assets/assets/
        //CSS/JS should load from local, fonts and images shoudl load from above path. make respective changes when doing these pages.
        //https://akash17112004.github.io/kgenew/about
        //https://akash17112004.github.io/kgenew/portfolio
        //https://akash17112004.github.io/kgenew/portfolio-details
        //https://akash17112004.github.io/kgenew/faq
        //https://akash17112004.github.io/kgenew/404
        //https://akash17112004.github.io/kgenew/services
        //https://akash17112004.github.io/kgenew/services-carousel
        //https://akash17112004.github.io/kgenew/advanced-technology
        //https://akash17112004.github.io/kgenew/product-details
        //https://akash17112004.github.io/kgenew/contact
        //https://akash17112004.github.io/kgenew/pricing




    }
}
