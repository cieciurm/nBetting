using Microsoft.AspNetCore.Mvc;
using NBetting.Domain.Entities;
using NBetting.EFMapping.Context;
using NBetting.Web.Controllers.Example;
using NBetting.Web.Infrastructure.Commands;
using NBetting.Web.Infrastructure.Events;
using NBetting.Web.Infrastructure.Queries;

namespace NBetting.Web.Controllers
{
    public class ExampleController : Controller
    {
        private readonly ICommandExecutor _commandExecutor;
        private readonly IQueryExecutor _queryExecutor;
        private readonly IEventPublisher _eventPublisher;

        public ExampleController(ICommandExecutor commandExecutor, IQueryExecutor queryExecutor, IEventPublisher eventPublisher)
        {
            _commandExecutor = commandExecutor;
            _queryExecutor = queryExecutor;
            _eventPublisher = eventPublisher;
        }

        public IActionResult Index()
        {
            var teams = _queryExecutor.Execute(new ExampleQuery());
            return Ok();
        }
    }

    
}
