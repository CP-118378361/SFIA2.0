using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        //numbersURL ; https://localhost:44377/
        //luckyStarsURL: https://localhost:44362/
        private IConfiguration Configuration;
    public MergeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var numbersService = $"{Configuration["numbersServiceURL"]}/Numbers";
            var numbersResponseCall = await new HttpClient().GetStringAsync(numbersService);

           
            var luckyStarsService = $"{Configuration["luckyStarsServiceURL"]}/LuckyStars";
            var luckyStarsResponseCall = await new HttpClient().GetStringAsync(luckyStarsService);

            var mergedResponse = $"{numbersResponseCall}{luckyStarsResponseCall}";
            return Ok(mergedResponse);
        }
    }
}
