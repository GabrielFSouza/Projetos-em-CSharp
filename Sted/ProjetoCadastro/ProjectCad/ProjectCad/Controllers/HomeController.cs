using Microsoft.AspNetCore.Mvc;
using ProjectCad.Models;
using System.Diagnostics;
using System.Reflection;

namespace ProjectCad.Controllers
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

            HomeModel home = new HomeModel(); /*Instanciando HomeModel*/
            home.Nome = "Gabriel Ferreira";
            home.Email = "gabrielferreira717@outlook.com";
            home.Telefone = "(19)992673942";

            return View(home);
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