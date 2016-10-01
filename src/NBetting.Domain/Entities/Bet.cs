namespace NBetting.Domain.Entities
{
    public class Bet : Entity
    {
        public User User { get; set; }

        public int UserId { get; set; }

        public Game Game { get; set; }

        public int GameId { get; set; }

        public bool IsDraw { get; set; }

        public Team Winner { get; set; }

        public int? WinnerId { get; set; }
    }
}