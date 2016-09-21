using System;

namespace NBetting.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeleteDate { get; set; }

        protected Entity()
        {
            CreationDate = DateTime.Now;
        }
    }
}
