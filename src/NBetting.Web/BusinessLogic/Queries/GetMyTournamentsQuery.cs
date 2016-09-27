using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBetting.Web.Infrastructure.Queries;
using NBetting.Web.Models;

namespace NBetting.Web.BusinessLogic.Queries
{
    public class GetMyTournamentsQuery : IQuery<IEnumerable<TournamentModel>>
    {
    }

    public class GetMyTournamentsQueryHandler : IQueryHandler<GetMyTournamentsQuery, IEnumerable<TournamentModel>>
    {
        public IEnumerable<TournamentModel> Handle(GetMyTournamentsQuery query)
        {
            return new List<TournamentModel>
            {
                new TournamentModel("name1", "description1", DateTime.Now, DateTime.Now.AddDays(1)),
                new TournamentModel("name2", "description2", DateTime.Now, DateTime.Now.AddDays(1))
            };
        }
    }
}
