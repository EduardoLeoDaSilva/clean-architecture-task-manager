using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Domain.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
        public DateTime? DeletedAt { get; protected set; }

        public Entity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;

            Validate();
        }

        public void UpdateLastChangeTime()
        {
            UpdatedAt = DateTime.Now;
        }

        protected abstract void Validate();
    }
}
