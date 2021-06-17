using Microsoft.AspNetCore.Mvc;
using Numbers.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace services.test.numberservice
{
   public class numbersTest
    {
        [Fact]
        public void GetTest()
        {
            NumbersController  numbersController = new NumbersController();
            var numbersControllerResult = numbersController.Get();

            Assert.NotNull(numbersControllerResult);
            Assert.IsType<ActionResult<string>>(numbersControllerResult);
        }
    }
}
