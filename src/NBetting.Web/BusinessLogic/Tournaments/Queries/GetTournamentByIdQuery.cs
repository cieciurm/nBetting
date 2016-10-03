using System;
using System.Data.Entity;
using System.Linq;
using NBetting.Domain.Entities;
using NBetting.Web.Helpers.Querybale;
using NBetting.Web.Infrastructure;
using NBetting.Web.Infrastructure.Queries;
using NBetting.Web.Models;

namespace NBetting.Web.BusinessLogic.Tournaments.Queries
{
    public class GetTournamentByIdQuery : IQuery<AddEditTournamentModel>
    {
        public int Id { get; set; }

        public GetTournamentByIdQuery(int id)
        {
            Id = id;
        }
    }

    public class GetTournamentByIdQueryHandler : IQueryHandler<GetTournamentByIdQuery, AddEditTournamentModel>
    {
        private readonly IRepository<Tournament> _repository;

        public GetTournamentByIdQueryHandler(IRepository<Tournament> repository)
        {
            _repository = repository;
        }

        public AddEditTournamentModel Handle(GetTournamentByIdQuery query)
        {
            var tournament = _repository.Query()
                .NotDeleted()
                .Where(t => t.Id == query.Id)
                .Include(t => t.Teams)
                .SingleOrDefault();

            return new AddEditTournamentModel(tournament);
        }
    }
}
