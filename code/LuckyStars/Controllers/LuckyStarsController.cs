using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LuckyStars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LuckyStarsController : ControllerBase
    {
        private static readonly int[] LuckyStars = new[]
        {
             10,20,30,40,50,60,70,80,90,100,110,120,130,140,150,160,170,180,190,200
        };

        [HttpGet]

        public ActionResult<string> Get()
        {
            var rnd = new Random();
            var returnIndex = rnd.Next(10, 200);
            return LuckyStars[returnIndex].ToString();
        }
    }
}
