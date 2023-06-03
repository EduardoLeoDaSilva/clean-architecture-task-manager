using CleanArchitecture.TaskManager.Common.Communication;
using CleanArchitecture.TaskManager.Common.Utils.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Application.UseCases.TaskManager.Commands
{
    public class UpdateProjectCommand : CommandMessage
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string ReponsibleUserId { get; set; }
        public List<string> DependenciesTask { get; set; }
        public override NotificationMessage Validate()
        {
           var errors = ObjectValidator<UpdateProjectCommand>.CreateValidator()
                .RuleFor(this, x => !string.IsNullOrEmpty(x.Name), "Name is invalid")
                .RuleFor(this, x => !string.IsNullOrEmpty(x.Description), "Description is not valid")
                .RuleFor(this, x => x.DueDate != null, "DueDate is not valid")
                .RuleFor(this, x => !string.IsNullOrEmpty(x.Status), "Status is not valid")
                .RuleFor(this, x => !string.IsNullOrEmpty(x.Priority), "Priority informed is not valid")
                .RuleFor(this, x => !string.IsNullOrEmpty(x.ReponsibleUserId), "Responsible User informed is not valid")
                .RuleFor(this, x => DependenciesTask != null, "Dependencies tasks is not valid")
                .Validate();

            if (errors.Any())
                return NotificationMessage.CreateInvalidNotification(errors.ToArray());

            return NotificationMessage.CreateValidNotification();
        }
    }
}
