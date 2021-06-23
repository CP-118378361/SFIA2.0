using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        private AppSettings Configuration;
        //numbersURL ; https://localhost:44377/
        //luckyStarsURL: https://localhost:44362/
    public MergeController(IOptions<AppSettings> settings)
        {
            Configuration = settings.Value;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var numbersService = $"{Configuration.NumbersServiceURL}/numbers";
            var serviceOneResponseCall = await new HttpClient().GetStringAsync(numbersService);

           
            var luckyStarsService = $"{Configuration.LuckyStarsServiceURL}/luckystars";
            var serviceTwoResponseCall = await new HttpClient().GetStringAsync(luckyStarsService);

            var mergedResponse = $"{serviceOneResponseCall}{serviceTwoResponseCall}";
            return Ok(mergedResponse);
        }
    }
}
