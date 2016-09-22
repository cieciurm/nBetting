using Microsoft.AspNetCore.Mvc;
using NBetting.Domain.Entities;
using NBetting.EFMapping.Context;
using NBetting.Web.Controllers.Example;
using NBetting.Web.Infrastructure.Commands;
using NBetting.Web.Infrastructure.Queries;

namespace NBetting.Web.Controllers
{
    public class ExampleController : Controller
    {
        private readonly ICommandExecutor _commandExecutor;
        private readonly IQueryExecutor _queryExecutor;

        public ExampleController(ICommandExecutor commandExecutor, IQueryExecutor queryExecutor)
        {
            _commandExecutor = commandExecutor;
            _queryExecutor = queryExecutor;
        }

        public IActionResult Index()
        {
            _queryExecutor.Execute(new ExampleQuery());
            return Ok();
        }
    }

    
}
