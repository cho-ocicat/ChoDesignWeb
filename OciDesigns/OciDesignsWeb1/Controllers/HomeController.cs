using Microsoft.AspNetCore.Mvc;
using OciDesignsWeb1.Models;
using System.Diagnostics;

namespace OciDesignsWeb1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //controls which page to view
        //asp-controller="Home" asp-action="Index"
        public IActionResult Index()
        {
            return View()
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Year12()
        {
            return View();
        }

        public IActionResult Year13()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
