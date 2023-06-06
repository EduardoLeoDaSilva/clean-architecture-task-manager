using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Application.DTOs
{
    public class TaskDTO
    {
        public string Name { get;  set; }
        public string Description { get;  set; }
        public DateTime DueDate { get;  set; }
        public TaskStatus Status { get;  set; }
        public Priority Priority { get;  set; }
        public UserDTO Responsible { get;  set; }
        public List<TaskDTO> DependecyTaks { get;  set; }
    }

    public enum TaskStatus
    {
        Pending,
        InProgress,
        Done
    }

    public enum Priority
    {
        Low,
        Medium,
        High
    }
}
