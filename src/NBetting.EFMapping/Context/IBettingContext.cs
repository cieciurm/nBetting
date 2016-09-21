using System.Data.Entity;
using NBetting.Domain.Entities;

namespace NBetting.EFMapping.Context
{
    public interface IBettingContext
    {
        DbSet<User> Users { get; set; }

        DbSet<Game> Games { get; set; }

        DbSet<ScoreBet> ScoreBets { get; set; }

        DbSet<Bet> Bets { get; set; }

        DbSet<Team> Teams { get; set; }

        DbSet<Tournament> Tournaments { get; set; }

        int Commit();
    }
}