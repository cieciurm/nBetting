using System;
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
        public AddEditTournamentModel Handle(GetTournamentByIdQuery query)
        {
            var model = new AddEditTournamentModel("Premier League", "", DateTime.Now, DateTime.Now.AddDays(14));
            model.Id = 1;
            model.Teams.Add(new TeamModel("Manchester United")
            {
                Id = 1
            });

            model.Teams.Add(new TeamModel("Chelsea")
            {
                Id = 2
            });

            return model;
        }
    }
}
