using FrontEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private AppSettings Configuration;
        public HomeController(IOptions<AppSettings> settings)
        {
            Configuration = settings.Value;
        }
    

        public async Task<IActionResult> Index()
        {
            var mergedService = $"{Configuration.mergedServiceURL}/merge";
            var serviceThreeResponseCall = await new HttpClient().GetStringAsync(mergedService);
            ViewBag.responseCall = serviceThreeResponseCall;
            return View();
        }

        

      
    }
}
