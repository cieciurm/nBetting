using System;
using System.Collections.Generic;
using System.Linq;
using NBetting.Domain.Entities;
using NBetting.EFMapping.Context;
using NBetting.Web.Infrastructure.Commands;

namespace NBetting.Web.Controllers.Startup
{
    public class GenerateExampleTournamentsCommand : ICommand
    {
    }

    public class GenerateExampleTournamentsCommandHandler : ICommandHandler<GenerateExampleTournamentsCommand>
    {
        private readonly IBettingContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public GenerateExampleTournamentsCommandHandler(IBettingContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public void Handle(GenerateExampleTournamentsCommand command)
        {
            if (_context.DbSet<Tournament>().Any() || _context.DbSet<Team>().Any())
            {
                return;
            }

            var kowalski = _context.DbSet<User>().AsQueryable().SingleOrDefault(x => x.Login == "Jan Kowalski") ?? new User("Jan Kowalski");

            var teams = new List<Team>
            {
                new Team("Legia Warszawa"),
                new Team("Wisła Kraków"),
                new Team("Lechia Gdańsk"),
                new Team("Zagłębie Lublin")
            };

            var tournament = new Tournament(kowalski, "Ekstraklasa", "Najlepsza liga świata", DateTime.Now, DateTime.Now.AddMonths(10), teams);
            _context.DbSet<Tournament>().Add(tournament);
            _unitOfWork.Commit();
        }
    }
}
