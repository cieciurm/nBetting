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
        private readonly IBettingContext _context;

        public ExampleQueryHandler(IBettingContext context)
        {
            _context = context;
        }

        public Team Handle(ExampleQuery query)
        {
            var team = _context.DbSet<Team>().FirstOrDefault();
            return team;
        }
    }
}
