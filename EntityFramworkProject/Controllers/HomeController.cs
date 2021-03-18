using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EntityFramworkProject.Models;
using BusinessLayer;

namespace EntityFramworkProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentComponent _studentComponent;

        public HomeController(ILogger<HomeController> logger, IStudentComponent studentComponent)
        {
            _logger = logger;
            _studentComponent = studentComponent;
        }

        public IActionResult Index()
        {
            var tempData = _studentComponent.GetStudents();
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
