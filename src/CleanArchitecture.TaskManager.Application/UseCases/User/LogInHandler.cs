using CleanArchitecture.TaskManager.Application.Commands;
using CleanArchitecture.TaskManager.Domain.Repositories;
using MediatR;

namespace CleanArchitecture.TaskManager.Application.UseCases.User
{
    public class LogInHandler : IRequestHandler<LogInCommand>
    {
        private readonly IUserRepository _userRepository;

        public LogInHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task Handle(LogInCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
