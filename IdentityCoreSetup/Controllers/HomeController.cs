using IdentityCoreSetup.Constants;
using IdentityCoreSetup.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IdentityCoreSetup.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
       

       
        public IActionResult Index()
        {
            return View();
        }

        
    }
}