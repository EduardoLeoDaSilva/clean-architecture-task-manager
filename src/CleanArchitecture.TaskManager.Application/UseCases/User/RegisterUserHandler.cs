using CleanArchitecture.TaskManager.Application.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Application.UseCases.User
{
    public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, bool>
    {
        public Task<bool> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
