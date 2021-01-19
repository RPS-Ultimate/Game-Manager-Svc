using System;
using Xunit;
using GameManager.Controllers;
using Moq;
using Microsoft.Extensions.Logging;

namespace GameManager_Tests
{
    public class UnitTest1
    {
        private readonly WeatherForecastController wfc;
        private readonly Mock<ILogger<WeatherForecastController>> mockILogger;
        public UnitTest1()
        {
            mockILogger = new Mock<ILogger<WeatherForecastController>>();
            wfc = new WeatherForecastController(mockILogger.Object);

        }

        [Fact]
        public void Creates_An_Ilogger()
        {
            //Given

            //When

            //Then
        }

        [Fact]
        public void Returns_An_Array()
        {
            Assert.NotEmpty(wfc.Get());
        }
    }
}
