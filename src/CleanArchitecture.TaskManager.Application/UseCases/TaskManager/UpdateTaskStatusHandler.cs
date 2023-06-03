using CleanArchitecture.TaskManager.Application.UseCases.TaskManager.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Application.UseCases.TaskManager
{
    public class UpdateTaskStatusHandler : IRequestHandler<UpdateTaskCommand>
    {
        public Task Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
