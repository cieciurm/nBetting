using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NBetting.Web.BusinessLogic.Queries;
using NBetting.Web.Infrastructure.Queries;

namespace NBetting.Web.Controllers
{
    public class TournamentsController : Controller
    {
        private readonly IQueryExecutor _queryExecutor;

        public TournamentsController(IQueryExecutor queryExecutor)
        {
            _queryExecutor = queryExecutor;
        }

        public IActionResult Index()
        {
            var tournaments = _queryExecutor.Execute(new GetMyTournamentsQuery());

            return Json(tournaments);
        }
    }
}
