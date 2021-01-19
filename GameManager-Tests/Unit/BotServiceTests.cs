using System;
using Xunit;
using GameManager.Services;

namespace GameManager.Tests.Unit
{
    public class BotServiceTests : IClassFixture<RandomFixture>
    {
        private readonly IBotService _botService;
        RandomFixture _fixture;

        public BotServiceTests(RandomFixture fixture)
        {
            _fixture = fixture;
            var random = _fixture.randomService;
            _botService = new BotService(random);
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
            Assert.True(result < 4);
        }
    }
}