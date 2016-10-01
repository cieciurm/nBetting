using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NBetting.Domain.Entities;
using NBetting.Web.BusinessLogic.Tournaments.Command;
using NBetting.Web.BusinessLogic.Tournaments.Queries;
using NBetting.Web.Infrastructure;
using NBetting.Web.Infrastructure.Commands;
using NBetting.Web.Infrastructure.Queries;
using NBetting.Web.Models;

namespace NBetting.Web.Controllers
{
    public class TournamentsController : Controller
    {
        private readonly IQueryExecutor _queryExecutor;
        private readonly ICommandExecutor _commandExecutor;
        private readonly IRepository<User> _users;

        public TournamentsController(IQueryExecutor queryExecutor, ICommandExecutor commandExecutor, IRepository<User> users)
        {
            _queryExecutor = queryExecutor;
            _commandExecutor = commandExecutor;
            _users = users;
        }

        public IActionResult Index()
        {
            var tournaments = _queryExecutor.Execute(new GetMyTournamentsQuery());

            return Json(tournaments);
        }

        [HttpGet]
        public JsonResult Get(int id)
        {
            var tournament = _queryExecutor.Execute(new GetTournamentByIdQuery(id));
            return Json(tournament);
        }

        [HttpPost]
        public IActionResult Save(AddEditTournamentModel model)
        {
            var firstUser = _users.Query().FirstOrDefault();
            var command = new AddEditTournamentCommand(model, firstUser?.Id ?? 0);
            _commandExecutor.Execute(command);
            return Ok();
        }
    }
}
