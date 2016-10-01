namespace NBetting.Domain.Entities
{
    public class Team : Entity
    {
        public Team(string name)
        {
            Name = name;
        }

        protected Team()
        {
        }

        public string Name { get; set; }

        public Tournament Tournament { get; set; }

        public int TournamentId { get; set; }
    }
}