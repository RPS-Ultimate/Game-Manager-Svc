using System;
using GameManager.Controllers;
using GameManager.Services;
using Moq;
using Xunit;

namespace GameManager.Tests.Unit
{
    public class BotControllerTests
    {
        private readonly BotController bot;
        private readonly Mock<IBotService> mockBotService;
        RandomFixture _fixture;

        public BotControllerTests()
        {
            mockBotService = new Mock<IBotService>();
            bot = new BotController(mockBotService.Object);
            _fixture = new RandomFixture();
        }

        [Fact]
        public void GetMoveReturnsAnInt()
        {
            var returnVal = _fixture.number;

            mockBotService.Setup(mBS => mBS.GetMove()).Returns(returnVal);

            var result = Assert.IsType<int>(bot.GetMove());
        }
    }
}