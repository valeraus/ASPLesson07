using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task01.Models;

namespace Task01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(FormModel model)
        {
            _logger.LogInformation("First: {First}", model.First);
            _logger.LogInformation("Second: {Second}", model.Second);
            _logger.LogInformation("Count: {Count}", model.Count);
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
    }
}