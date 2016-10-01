using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NBetting.Web.Controllers.Startup;
using NBetting.Web.Infrastructure.Commands;

// ReSharper disable once CheckNamespace
namespace NBetting.Web.Controllers
{

    public class StartupController : Controller
    {
        private readonly ICommandExecutor _commandExecutor;

        public StartupController(ICommandExecutor commandExecutor)
        {
            _commandExecutor = commandExecutor;
        }

        public IActionResult Start()
        {
            _commandExecutor.Execute(new GenerateExampleTournamentsCommand());
            return Ok();
        }
    }
}
