using System;
using System.Collections.Generic;

namespace NBetting.Domain.Entities
{
    public class Tournament : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public ICollection<Team> Teams { get; set; }

        public ICollection<Game> Games { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public Tournament(User owner,
            string name, 
            string description, 
            DateTime startDate, 
            DateTime finishDate, 
            ICollection<Team> teams)
           : this()
        {
            User = owner;
            Name = name;
            Description = description;
            StartDate = startDate;
            FinishDate = finishDate;
            Teams = teams;
        }

        protected Tournament()
        {
            Teams = new List<Team>();
            Games = new List<Game>();
        }
    }
}