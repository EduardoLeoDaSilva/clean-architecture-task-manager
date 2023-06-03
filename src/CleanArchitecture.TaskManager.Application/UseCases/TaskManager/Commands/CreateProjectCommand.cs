using CleanArchitecture.TaskManager.Common.Communication;
using CleanArchitecture.TaskManager.Common.Utils.Validators;

namespace CleanArchitecture.TaskManager.Application.UseCases.TaskManager.Commands
{
    public class CreateProjectCommand : CommandMessage
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ManagerId { get; set; }
        public DateTime? ConcludedAtDate { get; set; }

        public override NotificationMessage Validate()
        {

           var errors = ObjectValidator<CreateProjectCommand>.CreateValidator()
                .RuleFor(this, x => !string.IsNullOrEmpty(x.Title), "Title is invalid")
                .RuleFor(this, x => !string.IsNullOrEmpty(x.Description), "Description is invalid")
                .RuleFor(this, x => !string.IsNullOrEmpty(x.ManagerId), "ManagerId is invalid")
                .RuleFor(this, x => x.ConcludedAtDate != null, "Conclusion at date is invalid")
                .Validate();

            if (errors.Any())
                return NotificationMessage.CreateInvalidNotification(errors.ToArray());

            return NotificationMessage.CreateValidNotification();
        }
    }
}
