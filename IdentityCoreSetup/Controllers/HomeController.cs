using IdentityCoreSetup.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IdentityCoreSetup.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

       
        public IActionResult Index()
        {
            return View();
        }

        
    }
}