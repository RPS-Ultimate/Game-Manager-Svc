using System;
using GameManager.Models;
using GameManager.Services;
using Xunit;

namespace GameManager.Tests.Unit
{
    public class OutcomeServiceTests
    {
        private readonly IOutcomeService outcomeService;

        public OutcomeServiceTests()
        {
            outcomeService = new OutcomeService();
        }

        [Fact]
        public void DetermineUserWinsReturnsABool()
        {
            //Given
            var userMove = 1;
            var botMove = 0;
            //When
            var result = outcomeService.DetermineUserWins(userMove, botMove);
            //Then
            Assert.IsType<bool>(result);
        }

        [Fact]
        public void GetOutcomeReturnsExceptionWhenInvalidArgumentLessThanZeroIsGiven()
        {
            //Given
            var userMove = -1;
            //When

            //Then
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => outcomeService.GetOutcome(userMove));
        }

        [Fact]
        public void GetOutcomeReturnsExceptionWhenInvalidArgumentGreaterThanTwoIsGiven()
        {
            //Given
            var userMove = 3;
            //When

            //Then
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => outcomeService.GetOutcome(userMove));
        }

        [Fact]
        public void GetOutcomeReturnsAnOutcomeObject()
        {
            //Given
            var userMOve = 1;
            //When
            var result = outcomeService.GetOutcome(userMOve);
            //Then
            Assert.IsType<Outcome>(result);
        }
    }
}