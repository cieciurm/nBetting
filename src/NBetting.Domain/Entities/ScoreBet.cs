using NBetting.Domain.ValueObjects;

namespace NBetting.Domain.Entities
{
    public class ScoreBet : Bet
    {
        public Score Score { get; set; }
    }
}