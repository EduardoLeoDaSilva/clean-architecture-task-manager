using MediatR;

namespace CleanArchitecture.TaskManager.Application.UseCases.User
{
    public class LogInHandler : IRequestHandler<LoginCommand>
    {
        public Task Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
