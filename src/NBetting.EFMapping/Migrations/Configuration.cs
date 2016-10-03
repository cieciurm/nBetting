using System.Collections.Generic;
using NBetting.Domain.Entities;
using NBetting.EFMapping.Context;
namespace NBetting.EFMapping.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NBetting.EFMapping.Context.BettingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BettingContext context)
        {
            PopulateTournament(context);
        }

        private void PopulateTournament(BettingContext context)
        {
            var kowalski = context.DbSet<User>().AsQueryable().SingleOrDefault(x => x.Login == "Jan Kowalski") ?? new User("Jan Kowalski");

            var teams = new List<Team>
            {
                new Team("Legia Warszawa"),
                new Team("Wis³a Kraków"),
                new Team("Lechia Gdañsk"),
                new Team("Zag³êbie Lublin")
            };

            var tournament = new Tournament(kowalski, "Ekstraklasa", "Najlepsza liga œwiata", DateTime.Now, DateTime.Now.AddMonths(10), teams);
            context.DbSet<Tournament>().Add(tournament);
            context.SaveChanges();
        }
    }
}
