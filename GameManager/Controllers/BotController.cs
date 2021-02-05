using GameManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BotController : ControllerBase
    {
        private readonly IBotService _bot;

        public BotController(IBotService bot)
        {
            _bot = bot;
        }

        [HttpGet]
        public int GetMove()
        {
            return _bot.GetMove();
        }
    }
}