using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBetting.Domain.Entities;
using NBetting.EFMapping.Context;
using NBetting.Web.Infrastructure.Commands;

namespace NBetting.Web.Controllers.Example
{
    public class ExampleCommand : ICommand
    {
        public string Name { get; set; }
    }

    public class ExampleCommandHandler : ICommandHandler<ExampleCommand>
    {
        public void Handle(ExampleCommand command)
        {
            using (var context = new BettingContext())
            {
                var team = new Team
                {
                    Name = command.Name
                };

                context.Teams.Add(team);

                context.SaveChanges();
            }
        }
    }
}
