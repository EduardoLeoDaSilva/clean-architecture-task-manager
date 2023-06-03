using CleanArchitecture.TaskManager.Common.Communication;
using CleanArchitecture.TaskManager.Common.Utils.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Application.UseCases.TaskManager.Commands
{
    public class DeleteProjectCommand : CommandMessage
    {
        public override NotificationMessage Validate()
        {

            var errors = ObjectValidator<CreateProjectCommand>.CreateValidator()
                .RuleFor(this, x => x.Id != Guid.Empty, "Project Id invalid")
                .Validate();

            if (errors.Any())
                return NotificationMessage.CreateInvalidNotification(errors.ToArray());

            return NotificationMessage.CreateValidNotification();
        }
    }
}
