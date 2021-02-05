using GameManager.Services;

namespace GameManager.Tests.Unit
{
    public class RandomFixture
    {
        public IRandomService randomService { get; private set; }
        public int number { get; set; }

        public RandomFixture()
        {
            randomService = new RandomService();
            number = randomService.GenerateNumber();
        }
    }
}