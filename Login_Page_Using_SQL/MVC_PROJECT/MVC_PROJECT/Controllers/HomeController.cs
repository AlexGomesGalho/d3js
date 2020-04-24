using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_PROJECT.Models;

namespace MVC_PROJECT.Controllers
{
    public class HomeController : Controller
    {
        Db dbob = new Db();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public IActionResult Index([Bind] Ad_login ad)
        {
            int res = dbob.LoginCheck(ad);
            if (res == 1)
            {
                TempData["msg"] = "You Are welcome to admin section";
            }
            else
            {
                TempData["msg"] = "Admin ID or Password is Incorrect";
            }
            return View();
        }

        public IActionResult Index()
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
