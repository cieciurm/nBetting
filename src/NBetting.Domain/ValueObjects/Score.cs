using NBetting.Domain.Entities;

namespace NBetting.Domain.ValueObjects
{
    public class Score
    {
        public Team Team { get; set; }

        public int TeamId { get; set; }

        public byte TeamScore { get; set; }
    }
}