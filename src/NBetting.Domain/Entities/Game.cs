using System;
using NBetting.Domain.ValueObjects;

namespace NBetting.Domain.Entities
{
    public class Game : Entity
    {
        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public Team Team1 { get; set; }

        public int Team1Id { get; set; }

        public Team Team2 { get; set; }

        public int Team2Id { get; set; }

        public Tournament Tournament { get; set; }

        public int TournamentId { get; set; }

        public Score Team1Score { get; set; }

        public Score Team2Score { get; set; }
    }
}