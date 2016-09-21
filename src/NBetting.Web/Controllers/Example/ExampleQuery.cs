using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public Team Execute(ExampleQuery query)
        {
            using (var context = new BettingContext())
            {
                var team = context.Teams.FirstOrDefault();

                return team;
            }
        }
    }
}
