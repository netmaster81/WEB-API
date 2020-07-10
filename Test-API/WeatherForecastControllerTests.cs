using System;
using Xunit;
using WEB_API.Controllers;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using WEB_API;

namespace Test_API
{
    public class WeatherForecstTest
    {
        WeatherForecastController _controller;
        private readonly ILogger<WeatherForecastController> _logger;
        public WeatherForecstTest()
        {
            _controller = new WeatherForecastController(_logger);
        }
        [Fact]
        public void Check_WeatherForeReturnType()
        {
            var response = _controller.Get();
            Assert.IsAssignableFrom<IEnumerable<WeatherForecast>>(response);

        }
        [Fact]
        public void Check_WeatherForeReturnDataIsNotNull()
        {
            var response = _controller.Get();
            Assert.NotNull(response);

        }
    }
}

        
    
