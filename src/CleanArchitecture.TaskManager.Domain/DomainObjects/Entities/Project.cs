using CleanArchitecture.TaskManager.Common.Utils.Validators;
using CleanArchitecture.TaskManager.Domain.Entities;
using CleanArchitecture.TaskManager.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Domain.DomainObjects.Entities
{
    public class Project : Entity
    {
        public string Title { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime ToConcludedAt { get; private set; }
        public List<User> Members { get; private set; }
        public List<Task> Tasks { get; private set; }

        public Project(string title, string name, string description, User manager, DateTime toConcludedAt)
        {
            Title = title;
            Name = name;
            Description = description;
            Members = new List<User> { manager };
            ToConcludedAt = toConcludedAt;
        }

        protected override void Validate()
        {
            ObjectValidator<Project>.CreateValidator()
                .RuleFor<DomainException>(this, x => !string.IsNullOrEmpty(x.Title), "Title can't be empty")
                .RuleFor<DomainException>(this, x => !string.IsNullOrEmpty(x.Name), "Name can't be empty")
                .RuleFor<DomainException>(this, x => !string.IsNullOrEmpty(x.Description), "Description can't be empty")
                .RuleFor<DomainException>(this, x => x.Members.FirstOrDefault() != null && x.Members.FirstOrDefault()?.Id != Guid.Empty, "None Manager informed, informe one to create project!")
                .RuleFor<DomainException>(this, x => x.Description.Length > 10, "Description should have minimun length of 10 characteres")
                .RuleFor<DomainException>(this, x => x.Name.Length > 5, "Description should have minimun length of 5 characteres")
                .Validate();
        }

        public void AddTeamMember(User requerComingFrom,  User newMember)
        {
            if(requerComingFrom.IsAdmin || requerComingFrom.IsManager)
                this.Members.Add(newMember);

            throw new DomainException("You need to have level manager o higher to make this change");
        }


        public void ChangeToConcludeAt(User requerComingFrom, DateTime newToConcluedAt)
        {
            if(newToConcluedAt > ToConcludedAt && (requerComingFrom.IsAdmin || requerComingFrom.IsManager))
                this.ToConcludedAt  = newToConcluedAt;
            throw new DomainException("You need to have level manager o higher to make this change");
        }


        public List<Task> ListTasks(User requerComingFrom)
        {
            if (requerComingFrom.IsAdmin || requerComingFrom.IsManager && this.Members.Any(member => member.Id == requerComingFrom.Id))
                return this.Tasks;

            return  Tasks.Where(task => task.Responsible.Id == requerComingFrom.Id).ToList();
        }

    }
}
