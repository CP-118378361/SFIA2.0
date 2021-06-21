using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FrontEnd.Models;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Merge;

namespace FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        //public HomeController(IOptions<AppSettings> options)
        //private IConfiguration Configuration;
        //public HomeController(IConfiguration configuration)
            public HomeController(IOptions<AppSettings> options)
        {
            Configuration = options.Value;
        }
        private AppSettings Configuration;
        public async Task<IActionResult> Index()
        {
            //var mergedService = "https://localhost:44321/merge";
            var mergedService = $"{Configuration["MergedServiceURL"]}/merge";
            var serviceThreeResponseCall = await new HttpClient().GetStringAsync(mergedService);
            ViewBag.responseCall = serviceThreeResponseCall;
            return View();
        }
    }
}
