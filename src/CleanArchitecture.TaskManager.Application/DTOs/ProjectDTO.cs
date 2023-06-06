using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Application.DTOs
{
    public class ProjectDTO
    {
        public string Title { get;  set; }
        public string Name { get;  set; }
        public string Description { get;  set; }
        public DateTime ToConcludedAt { get;  set; }
        public List<UserDTO> Members { get; private set; }
        public List<TaskDTO> Tasks { get;  set; }
    }
}
