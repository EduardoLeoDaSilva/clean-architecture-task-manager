using CleanArchitecture.TaskManager.Application.UseCases.TaskManager.Commands;
using CleanArchitecture.TaskManager.Domain.Repositories;
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
        private readonly ITaskRepository _taskRepository;

        public UpdateTaskStatusHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public Task Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
