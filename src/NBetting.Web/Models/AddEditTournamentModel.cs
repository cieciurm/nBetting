using System;
using System.Collections.Generic;

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
    }
}
