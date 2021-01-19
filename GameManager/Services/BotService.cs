using System;
using System.Threading.Tasks;

namespace GameManager.Services
{
    public class BotService : IBotService
    {
        private readonly IRandomService _random;
        private readonly int rInt;

        public BotService(IRandomService random)
        {
            _random = random;
            rInt = _random.GenerateNumber();
        }

        public int GetMove()
        {
            return rInt;
        }
    }
}