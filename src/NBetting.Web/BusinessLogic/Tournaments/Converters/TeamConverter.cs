using NBetting.Domain.Entities;
using NBetting.Web.Models;

namespace NBetting.Web.BusinessLogic.Tournaments.Converters
{
    public class TeamConverter
    {
        public static Team Convert(TeamModel team)
        {
            return new Team(team.Name);
        }
    }
}
