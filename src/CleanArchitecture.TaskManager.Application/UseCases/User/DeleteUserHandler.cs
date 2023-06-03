using CleanArchitecture.TaskManager.Application.Commands;
using MediatR;

namespace CleanArchitecture.TaskManager.Application.UseCases.User
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand>
    {
        public Task Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
