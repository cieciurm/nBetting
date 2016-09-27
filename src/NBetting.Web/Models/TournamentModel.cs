using System;

namespace NBetting.Web.Models
{
    public class TournamentModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public TournamentModel()
        {
        }

        public TournamentModel(string name, string description, DateTime startDate, DateTime finishDate)
        {
            Name = name;
            Description = description;
            StartDate = startDate;
            FinishDate = finishDate;
        }
    }
}
