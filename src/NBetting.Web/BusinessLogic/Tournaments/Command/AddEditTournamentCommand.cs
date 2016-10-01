using System;
using System.Linq;
using NBetting.Domain.Entities;
using NBetting.EFMapping.Context;
using NBetting.Web.BusinessLogic.Tournaments.Converters;
using NBetting.Web.Infrastructure;
using NBetting.Web.Infrastructure.Commands;
using NBetting.Web.Models;

namespace NBetting.Web.BusinessLogic.Tournaments.Command
{
    public class AddEditTournamentCommand : ICommand
    {
        public AddEditTournamentModel Tournament { get; set; }
        public int UserId { get; set; }

        public AddEditTournamentCommand(AddEditTournamentModel tournament, int userId)
        {
            Tournament = tournament;
            UserId = userId;
        }
    }

    public class AddEditTournamentCommandHandler : ICommandHandler<AddEditTournamentCommand>
    {
        private readonly IRepository<Tournament> _torunamentRepository;
        private readonly IRepository<User> _usersRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AddEditTournamentCommandHandler(IRepository<Tournament> torunamentRepository, IUnitOfWork unitOfWork, IRepository<User> usersRepository)
        {
            _torunamentRepository = torunamentRepository;
            _unitOfWork = unitOfWork;
            _usersRepository = usersRepository;
        }

        public void Handle(AddEditTournamentCommand command)
        {
            if (command.Tournament.Id <= 0)
            {
                Add(command.Tournament, command.UserId);
            }
            else
            {
                Edit(command.Tournament);
            }

            _unitOfWork.Commit();
        }

        private Tournament Add(AddEditTournamentModel model, int userId)
        {
            var teams = model.Teams.Select(TeamConverter.Convert).ToList();

            var owner = _usersRepository.Get(userId);
            if(owner == null)
                throw new ArgumentException("Bad user id");
            
            var tournament = new Tournament(owner, model.Name, model.Description, model.StartDate, model.EndDate, teams);
            _torunamentRepository.AddOrEdit(tournament);
            return tournament;
        }

        private Tournament Edit(AddEditTournamentModel model)
        {
            var tournament = _torunamentRepository.Get(model.Id);
            //TODO: Usuniecie teamow ktorych juz nie ma na liscie
            throw new NotImplementedException("Edit tournament method is not implemented yet.");
        }
    }
}
