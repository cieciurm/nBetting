using System;
using NBetting.Domain.Entities;

namespace NBetting.Web.Models
{
    public class TournamentModel : IModelWithId
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public TournamentModel()
        {
        }

        public TournamentModel(int id, string name, string description, DateTime startDate, DateTime finishDate)
        {
            Id = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public TournamentModel(Tournament entity)
            : this(entity.Id, entity.Name, entity.Description, entity.StartDate, entity.FinishDate)
        {
        }
    }
}
