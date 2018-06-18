using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using swlunch.data;
using swlunch.mvc.Models;
using swlunch.service;

namespace swlunch.mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly LunchService _service;
        public HomeController(LunchService service){
            _service = service;
        }
        public IActionResult Index()
        {
            Restaurants variable = _service.testClass();
            return View();
        }

        public IActionResult About()
        {            
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
