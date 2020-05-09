using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoWebApp1.Models;
using DemoWebApp.Mathematics;

namespace DemoWebApp1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var calculator = new Calculator();
            var sum = calculator.Sum(10, 20);
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
