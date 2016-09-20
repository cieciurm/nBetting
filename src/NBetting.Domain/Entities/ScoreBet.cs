using NBetting.Domain.ValueObjects;

namespace NBetting.Domain.Entities
{
    public class ScoreBet : Bet
    {
        public Score Team1Score { get; set; }

        public Score Team2Score { get; set; }
    }
}