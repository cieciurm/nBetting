using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBetting.Domain.Entities;
using NBetting.Web.Infrastructure;
using NBetting.Web.Infrastructure.Queries;
using NBetting.Web.Models;

namespace NBetting.Web.BusinessLogic.Tournaments.Queries
{
    public class GetMyTournamentsQuery : IQuery<IList<TournamentModel>>
    {
        public int UserId { get; set; }

        public GetMyTournamentsQuery(int userId)
        {
            UserId = userId;
        }
    }

    public class GetMyTournamentsQueryHandler : IQueryHandler<GetMyTournamentsQuery, IList<TournamentModel>>
    {
        private readonly IRepository<User> _usersRepository;
        private readonly IRepository<Tournament> _tournamentsRepository;

        public GetMyTournamentsQueryHandler(IRepository<User> usersRepository, IRepository<Tournament> tournamentsRepository)
        {
            _usersRepository = usersRepository;
            _tournamentsRepository = tournamentsRepository;
        }

        public IList<TournamentModel> Handle(GetMyTournamentsQuery query)
        {
            var user = _usersRepository.Get(query.UserId);
            if(user == null)
                throw new ArgumentException("Bad user id.");

            var tournaments = _tournamentsRepository.Query().Where(x => x.User.Id == query.UserId);
            return tournaments.Select(x => new TournamentModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                StartDate = x.StartDate,
                FinishDate = x.FinishDate,
            }).ToList();
        }
    }
}
