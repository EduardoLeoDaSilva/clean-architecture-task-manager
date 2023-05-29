using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Domain.DomainObjects.Entities
{
    internal class Project : IAggregateRoot
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
