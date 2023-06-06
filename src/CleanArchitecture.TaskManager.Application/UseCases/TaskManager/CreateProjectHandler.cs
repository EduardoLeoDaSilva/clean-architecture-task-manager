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
    public class CreateProjectHandler : IRequestHandler<CreateProjectCommand>
    {
        private readonly IProjectRepository _projectRepository;

        public CreateProjectHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public Task Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
