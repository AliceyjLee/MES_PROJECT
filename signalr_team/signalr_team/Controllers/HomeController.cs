using Microsoft.AspNetCore.Mvc;
using signalr_team.Models;
using System.Diagnostics;

namespace signalr_team.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Img()
        {
            return View();
        }

        // 라즈베리파이 실시간 영상
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Userinfo()
        {
            return View();
        }
        public IActionResult UserAuth()
        {
            return View();
        }

        public IActionResult ProductRegister()
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
    }
}