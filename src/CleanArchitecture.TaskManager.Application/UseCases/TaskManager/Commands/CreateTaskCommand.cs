using CleanArchitecture.TaskManager.Common.Communication;
using CleanArchitecture.TaskManager.Common.Utils.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Application.UseCases.TaskManager.Commands
{
    public class CreateTaskCommand : CommandMessage
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string Priority { get; set; }
        public string UserId { get; set; }

        public override NotificationMessage Validate()
        {
            var errors = ObjectValidator<CreateTaskCommand>.CreateValidator()
                .RuleFor(this, x => !string.IsNullOrEmpty(x.Name), "")
                .RuleFor(this, x =>!string.IsNullOrEmpty(x.Description), "")
                .RuleFor(this, x => x.DueDate != null, "")
                .RuleFor(this, x => !string.IsNullOrEmpty(x.UserId), "")
                .Validate();

            if (errors.Any())
                return NotificationMessage.CreateInvalidNotification(errors.ToArray());

            return NotificationMessage.CreateValidNotification();
        }
    }
}
