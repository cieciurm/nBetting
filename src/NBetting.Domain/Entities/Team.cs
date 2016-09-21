namespace NBetting.Domain.Entities
{
    public class Team : Entity
    {
        public string Name { get; set; }

        public Tournament Tournament { get; set; }

        public int? TournamentId { get; set; }
    }
}