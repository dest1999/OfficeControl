using Microsoft.AspNetCore.Mvc;
using OfficeControl.Models;
using System.Diagnostics;

namespace OfficeControl.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<Employee> employeeRepository;
        public HomeController(ILogger<HomeController> logger, IRepository<Employee> repository)
        {
            _logger = logger;
            employeeRepository = repository;
        }

        public IActionResult Index()
        {
            var employees = employeeRepository.GetAll();
            return View(employees);
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