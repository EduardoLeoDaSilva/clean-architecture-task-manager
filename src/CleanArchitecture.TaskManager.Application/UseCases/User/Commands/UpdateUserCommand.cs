using CleanArchitecture.TaskManager.Common.Communication;
using CleanArchitecture.TaskManager.Common.Utils.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Application.Commands
{
    public class UpdateUserCommand : CommandMessage
    {

        public override NotificationMessage Validate()
        {
            var errors =  ObjectValidator<UpdateUserCommand>.CreateValidator()
                .RuleFor(this, x => x.Id != Guid.Empty, "User id not informed or not valid").Validate();

            if (errors.Any())
                return NotificationMessage.CreateInvalidNotification(errors.ToArray());

            return NotificationMessage.CreateValidNotification();
        }
    }
}
