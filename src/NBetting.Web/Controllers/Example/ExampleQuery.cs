using System.Linq;
using NBetting.Domain.Entities;
using NBetting.EFMapping.Context;
using NBetting.Web.Infrastructure.Queries;

namespace NBetting.Web.Controllers.Example
{
    public class ExampleQuery : IQuery<Team>
    {
    }

    public class ExampleQueryHandler : IQueryHandler<ExampleQuery, Team>
    {
        public Team Handle(ExampleQuery query)
        {
            using (var context = new BettingContext())
            {
                var team = context.Teams.FirstOrDefault();

                return team;
            }
        }
    }
}
