using System;
using Xunit;
using GameManager.Services;

namespace GameManager.Tests.Unit
{
    public class BotServiceTests
    {
        private readonly IBotService _botService;

        public BotServiceTests()
        {
            _botService = new BotService();
        }

        [Fact]
        public void GetReturnsAnIntLessThanFour()
        {
            //Given
            
            //When
            var result = _botService.GetMove();
            //Then
            Assert.IsType<int>(result);
            Assert.True(result < 4);
        }

        [Fact]
        public void GetReturnsAnIntGreaterThanZero()
        {
            //Given
            
            //When
            var result = _botService.GetMove();
            //Then
            Assert.IsType<int>(result);
            Assert.True(result > 0);
        }
    }
}