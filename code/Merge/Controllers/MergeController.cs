using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        //numberURL ; https://localhost:44377/
        //lucky stars: https://localhost:44362/
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var numbersService = "https://localhost:44377/numbers";
            var numbersResponseCall = await new HttpClient().GetStringAsync(numbersService);

            var luckyStarsService = "https://localhost:44362/luckyStars";
            var luckyStarsResponseCall = await new HttpClient().GetStringAsync(luckyStarsService);

            var mergedResponse = $"{numbersResponseCall}{luckyStarsResponseCall}";
            return Ok(mergedResponse);
        }
    }
}
