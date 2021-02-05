using GameManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OutcomeController : ControllerBase
    {
        private readonly IOutcomeService outcomeService;

        public OutcomeController()
        {
            outcomeService = new OutcomeService();
        }

        [HttpGet("{userMove}")]
        public IActionResult GetOutcome(int userMove)
        {
            return Ok(outcomeService.GetOutcome(userMove));
        }
    }
}