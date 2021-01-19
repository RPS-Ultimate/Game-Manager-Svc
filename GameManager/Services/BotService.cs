using System;
using System.Threading.Tasks;

namespace GameManager.Services
{
    public class BotService : IBotService
    {
        public BotService()
        {

        }

        public string Get()
        {
            return "Name";
        }
    }
}