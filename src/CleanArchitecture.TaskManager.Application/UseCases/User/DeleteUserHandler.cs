using CleanArchitecture.TaskManager.Application.Commands;
using CleanArchitecture.TaskManager.Domain.Repositories;
using MediatR;

namespace CleanArchitecture.TaskManager.Application.UseCases.User
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
