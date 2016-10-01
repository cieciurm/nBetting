using System.Data.Entity;
using NBetting.Domain.Entities;
using NBetting.Domain.ValueObjects;

namespace NBetting.EFMapping.Context
{
    public static class DbModelBuilderHelper
    {
        public static void BuildModel(DbModelBuilder modelBuilder)
        {
            modelBuilder.ComplexType<Score>();

            modelBuilder.Entity<Tournament>()
                .HasRequired(o => o.User)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasRequired(t => t.Tournament)
                .WithMany(x => x.Teams)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Game>()
                .HasRequired(g => g.Tournament)
                .WithMany(t => t.Games)
                .HasForeignKey(g => g.TournamentId);

            modelBuilder.Entity<Game>()
                .HasOptional(x => x.Team1)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Game>()
                .HasOptional(x => x.Team2)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bet>()
                .HasRequired(b => b.User)
                .WithMany()
                .HasForeignKey(s => s.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
