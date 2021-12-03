using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Odev_02_WebAPP.Filters;
using Odev_02_WebAPP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Odev_02_WebAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private const int authlevel = 2;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AuthFilter(authlevel)]
        public IActionResult SecondLevel()
        {
            return View();
        }

        [AuthFilter(authlevel)]
        public IActionResult ThirdLevel()
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
