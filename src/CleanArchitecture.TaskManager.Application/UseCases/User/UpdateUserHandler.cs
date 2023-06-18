using CleanArchitecture.TaskManager.Application.Commands;
using CleanArchitecture.TaskManager.Domain.Repositories;
using MediatR;

namespace CleanArchitecture.TaskManager.Application.UseCases.User
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public UpdateUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
