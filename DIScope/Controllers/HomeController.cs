using DIScope.Models;
using DIScope.Sevices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using IServiceScope = DIScope.Sevices.Interfaces.IServiceScope;

namespace DIScope.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServiceScope _serviceScope;
        private readonly IServiceSingleton _serviceSingleton;
        private readonly IServiceTransient _serviceTransient;

        private readonly IServiceScope _serviceScope1;
        private readonly IServiceSingleton _serviceSingleton1;
        private readonly IServiceTransient _serviceTransient1;

        public HomeController(ILogger<HomeController> logger,
            IServiceTransient serviceTransient,
            IServiceSingleton serviceSingleton,
            IServiceScope serviceScope,
            IServiceTransient serviceTransient1,
            IServiceSingleton serviceSingleton1,
            IServiceScope serviceScope1)
        {
            _logger = logger;
            _serviceSingleton = serviceSingleton;
            _serviceTransient = serviceTransient;
            _serviceScope = serviceScope;

            _serviceSingleton1 = serviceSingleton1;
            _serviceTransient1 = serviceTransient1;
            _serviceScope1 = serviceScope1;
        }

        public IActionResult Index()
        {
            ViewBag.ServiceScopeId = _serviceScope.GetId();
            ViewBag.ServiceSingletonId = _serviceSingleton.GetId();
            ViewBag.ServiceTransientId = _serviceTransient.GetId();

            ViewBag.ServiceScopeId1 = _serviceScope1.GetId();
            ViewBag.ServiceSingletonId1 = _serviceSingleton1.GetId();
            ViewBag.ServiceTransientId1 = _serviceTransient1.GetId();
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.ServiceScopeId = _serviceScope.GetId();
            ViewBag.ServiceSingletonId = _serviceSingleton.GetId();
            ViewBag.ServiceTransientId = _serviceTransient.GetId();

            ViewBag.ServiceScopeId1 = _serviceScope1.GetId();
            ViewBag.ServiceSingletonId1 = _serviceSingleton1.GetId();
            ViewBag.ServiceTransientId1 = _serviceTransient1.GetId();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}