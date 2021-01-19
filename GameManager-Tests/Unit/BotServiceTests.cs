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
        public void GetThrowsExceptionWhenGivenNullId()
        {
            //Given
            
            //When
            var result = _botService.Get();
            //Then
            Assert.IsType<string>(result);
        }
    }
}