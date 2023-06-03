using CleanArchitecture.TaskManager.Application.Commands;
using MediatR;

namespace CleanArchitecture.TaskManager.Application.UseCases.User
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand>
    {
        public Task Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
