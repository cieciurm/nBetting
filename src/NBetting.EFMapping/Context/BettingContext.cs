using System.Data.Entity;
using NBetting.Domain.Entities;

namespace NBetting.EFMapping.Context
{
    public class BettingContext : DbContext, IBettingContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<ScoreBet> ScoreBets { get; set; }

        public DbSet<Bet> Bets { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }

        public BettingContext() : base(ConnectionStringProvider.GetConnectionString())
        {
        }

        public int Commit()
        {
            return SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            DbModelBuilderHelper.BuildModel(modelBuilder);
        }
    }
}
