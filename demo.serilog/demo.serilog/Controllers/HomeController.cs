using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using demo.serilog.Models;
using InfrastructureLogger;

namespace demo.serilog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            LoggerAdapter.Debug("Logs Debug");
            LoggerAdapter.Information("Logs Information");
            LoggerAdapter.Warning("Logs Warning");
            LoggerAdapter.Error("Logs Error");
            LoggerAdapter.Fatal("Logs Fatal");
            return View();
        }
    }
}
