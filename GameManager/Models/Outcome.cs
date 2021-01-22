namespace GameManager.Models
{
    public class Outcome
    {
        public int UserMove { get; set; }
        public int BotMove { get; set; }
        public bool UserWins { get; set; }
        public bool IsADraw { get; set; }
    }
}