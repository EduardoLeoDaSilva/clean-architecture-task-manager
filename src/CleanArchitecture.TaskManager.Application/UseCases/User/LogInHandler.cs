using MediatR;

namespace CleanArchitecture.TaskManager.Application.UseCases.User
{
    public class LogInHandler : IRequestHandler<LoginCommand>
    {
        private readonly IUserRepository _userRepository;

        public Task Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
