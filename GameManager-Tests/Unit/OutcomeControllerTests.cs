using GameManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace GameManager.Tests.Unit
{
    public class OutcomeControllerTests
    {
        private readonly OutcomeController outcomeController;
        public OutcomeControllerTests()
        {
            outcomeController = new OutcomeController();
        }

        [Fact]
        public void GetOutcomeReturnsAStatusCode200OnValidRequest()
        {
            //Given
            var userMove = 1;
            //When
            var result = outcomeController.GetOutcome(userMove);
            //Then
            Assert.IsType<OkObjectResult>(result);
        }
    }
}