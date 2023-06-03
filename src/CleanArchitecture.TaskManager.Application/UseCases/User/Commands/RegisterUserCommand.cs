using CleanArchitecture.TaskManager.Common.Communication;
using CleanArchitecture.TaskManager.Common.Utils.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Application.Commands

{
    public class RegisterUserCommand : CommandMessage
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public override NotificationMessage Validate()
        {
           var errors = ObjectValidator<RegisterUserCommand>.CreateValidator()
                .RuleFor(this, x => string.IsNullOrEmpty(x.Name), "Name is invalid!")
                .RuleFor(this, x => string.IsNullOrEmpty(x.Password), "Password is invalid")
                .RuleFor(this, x => string.IsNullOrEmpty(x.Password), "Email is invalid")
                .RuleFor(this, x => string.IsNullOrEmpty(UserType), "User Role is not valid")
                .Validate();

            if (errors.Any())
                return NotificationMessage.CreateInvalidNotification(errors.ToArray());

            return NotificationMessage.CreateValidNotification();
        }

    }
}
