using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using SignalR.Teste.Hubs;
using SignalR.Teste.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Teste.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHubContext<ChatHub> _context;

        public HomeController(ILogger<HomeController> logger, IHubContext<ChatHub> context)
        {
            _context = context;
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View();
        }


    }
}
