using System;
using System.Collections.Generic;
using NBetting.Domain.Entities;

namespace NBetting.Web.Models
{
    public class AddEditTournamentModel : IModelWithId
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<TeamModel> Teams { get; set; }

        public AddEditTournamentModel()
        {
            Teams = new List<TeamModel>();
        }

        public AddEditTournamentModel(string name, string description, DateTime startDate, DateTime endDate)
            : this()
        {
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }

        public AddEditTournamentModel(Tournament tournament)
            :this(tournament.Name, tournament.Description, tournament.StartDate, tournament.FinishDate)
        {
            Id = tournament.Id;

            foreach (var team in tournament.Teams)
            {
                Teams.Add(new TeamModel(team));
            }
        }
    }

    public class TeamModel : IModelWithId
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TeamModel(string name)
        {
            Name = name;
        }

        public TeamModel()
        {
        }

        public TeamModel(Team team)
        {
            Id = team.Id;
            Name = team.Name;
        }
    }
}
