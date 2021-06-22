using Merge;
using Merge.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace services.test.mergeservice
{
    public class mergeTest
    {
        private AppSettings appSettings = new AppSettings()
        {
            NumbersServiceURL = "https://cp-app-numbers.azurewebsites.net",
            LuckyStarsServiceURL = "https://chloe-app-star.azurewebsites.net"

        };
        [Fact]
        public async void GetTest()
        {
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(x => x.Value).Returns(appSettings);

            MergeController mergeController = new MergeController(options.Object);
            var mergeControllerResult = await mergeController.Get();

            Assert.NotNull(mergeControllerResult);
            Assert.IsType<OkObjectResult>(mergeControllerResult);
        }


    }
}
