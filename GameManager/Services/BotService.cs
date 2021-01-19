using System;
using System.Threading.Tasks;

namespace GameManager.Services
{
    public class BotService : IBotService
    {
        private readonly Random random;
        private readonly int rInt;

        public BotService()
        {
            random = new Random();
            rInt = random.Next(1, 3);
        }

        public int GetMove()
        {
            return rInt;
        }
    }
}