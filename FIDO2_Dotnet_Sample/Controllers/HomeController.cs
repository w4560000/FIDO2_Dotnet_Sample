using Microsoft.AspNetCore.Mvc;

namespace FIDO2_Dotnet_Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult MFA()
        {
            return View();
        }

        public IActionResult Passwordless()
        {
            return View();
        }

        public IActionResult Usernameless()
        {
            return View();
        }
    }
}