using GameManager.Models;

namespace GameManager.Services
{
    public interface IOutcomeService
    {
        Outcome GetOutcome(int userMove);
        bool DetermineUserWins(int userMove, int botMove);
    }
}