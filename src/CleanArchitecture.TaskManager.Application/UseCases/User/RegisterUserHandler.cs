using CleanArchitecture.TaskManager.Application.Commands;
using CleanArchitecture.TaskManager.Domain.Repositories;
using MediatR;

namespace CleanArchitecture.TaskManager.Application.UseCases.User
{
    public class RegisterUserHandler : IRequestHandler<RegisterUserCommand>
    {
        private readonly IUserRepository _userRepository;
        public RegisterUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
