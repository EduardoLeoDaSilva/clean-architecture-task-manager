using CleanArchitecture.TaskManager.Common.Utils.Validators;
using CleanArchitecture.TaskManager.Domain.DomainObjects.Enums;
using CleanArchitecture.TaskManager.Domain.Entities;
using CleanArchitecture.TaskManager.Domain.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArchitecture.TaskManager.Domain.DomainObjects.Entities
{
    public class Task : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime DueDate { get; private set; }
        public DomainObjects.Enums.TaskStatus Status { get; private set; }
        public Priority Priority { get; private set; }
        public User Responsible { get; private set; }
        public List<Task> DependecyTaks { get; private set; }

        public Task(string name, string description, DateTime dueDate, Priority priority, User responsible)
        {
            Name = name;
            Description = description;
            DueDate = dueDate;
            Priority = priority;
            Responsible = responsible;

            Status = Enums.TaskStatus.Pending;
        }

        protected override void Validate()
        {
            ObjectValidator<Task>.CreateValidator()
                .RuleFor<DomainException>(this, x => !string.IsNullOrEmpty(x.Name), "Name can't be empty")
                .RuleFor<DomainException>(this, x => !string.IsNullOrEmpty(x.Description), "Description can't be empty")
                .RuleFor<DomainException>(this, x => x.Responsible != null, "You should inform a member responsible for the task")
                .RuleFor<DomainException>(this, x => x.DueDate > DateTime.Now, "Due date should me greater than current time")
                .RuleFor<DomainException>(this, x => x.Description.Length > 10, "Description should have minimun length of 10 characteres")
                .RuleFor<DomainException>(this, x => x.Name.Length > 5, "Description should have minimun length of 5 characteres");
        }

        public void UpdateName(string name)
        {
            this.Name = name;
        }

        public void StartTask(User requestComingFrom)
        {
            if (requestComingFrom.Id != Responsible.Id)
                throw new DomainException("Only the member responsible for the task can initiate it");

            if (Status != Enums.TaskStatus.Pending)
                throw new DomainException("Task has already started!");

            if(this.DependecyTaks.Any(x => x.Status != Enums.TaskStatus.Done))
                throw new DomainException("All dependencies tasks should done");

            Status = Enums.TaskStatus.Pending;
        }

        public void CompleTask(User requestComingFrom)
        {
            if (requestComingFrom.Id != Responsible.Id)
                throw new DomainException("Only the member responsible for the task can complete it");

            if (Status != Enums.TaskStatus.InProgress)
                throw new DomainException("Task can not be marked as done because the transition is not valid");

            Status = Enums.TaskStatus.Done;
        }
    }
}
