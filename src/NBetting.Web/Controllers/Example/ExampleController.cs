using Microsoft.AspNetCore.Mvc;
using NBetting.Domain.Entities;
using NBetting.EFMapping.Context;
using NBetting.Web.Controllers.Example;
using NBetting.Web.Infrastructure.Commands;

namespace NBetting.Web.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            //var handler = new ExampleCommandHandler();
            //handler.Execute(new ExampleCommand {Name = "name #1"});

            var handler = new ExampleQueryHandler();
            var team = handler.Execute(new ExampleQuery());

            return Ok(team);
        }
    }

    
}
