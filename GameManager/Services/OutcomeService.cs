using GameManager.Models;

namespace GameManager.Services
{
    public class OutcomeService : IOutcomeService
    {
        private readonly IRandomService randomService;
        public OutcomeService()
        {
            randomService = new RandomService();
        }

        public Outcome GetOutcome(int userMove)
        {
            var botMove = randomService.GenerateNumber();
            var userWins = DetermineUserWins(userMove, botMove);
            var isADraw = userMove == botMove ? true : false;
            var outcome = new Outcome() {
                UserMove = userMove,
                BotMove = botMove,
                UserWins = userWins,
                IsADraw = isADraw
            };

            return outcome;
        }

        public bool DetermineUserWins(int userMove, int botMove)
        {
            if ((userMove == 0 && botMove == 1) || 
                (userMove == 1 && botMove == 2) || 
                (userMove == 2 && botMove == 0) || 
                (userMove == botMove))
            {
                return false;
            } 

            return true;
        }
    }
}