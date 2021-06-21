using LuckyStars.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace services.test.luckystarsservice
{
    public class LuckystarsTest
    {
        [Fact]
        
        public void GetTest()
        {
            LuckyStarsController LuckyStarsController = new LuckyStarsController();
            var LuckystarsControllerResult = LuckyStarsController.Get();

            Assert.NotNull(LuckystarsControllerResult);
            Assert.IsType<ActionResult<string>>(LuckystarsControllerResult);

        }
    }
}
