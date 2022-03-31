using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPi.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController(null);

        [Fact]
        public void GetReturnGreetingMyName()
        {
            var returnValue = controller.Get("John");
            Assert.Equal("Hello John!", returnValue.Value);
        }
    }
}
