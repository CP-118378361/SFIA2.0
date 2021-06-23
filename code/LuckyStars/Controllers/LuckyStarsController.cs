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
        private static readonly string[] Luckystars = new[]
        {
            "Protostar","T Tauri Star", "Sequence Star", "Red Dwarf", "Red Giant Star", "White Dwarf", "Supergaint Star", "Neutron Star", "Variable Star", "Runaway Star", "Hypervelocity Star", "Intergalactic Star", "Halo Star"
        };

        [HttpGet]

        public ActionResult<string> Get()
        {
            var rnd = new Random();
            var returnIndex = rnd.Next(0, 12);
            return Luckystars[returnIndex].ToString();
        }
    }
}
