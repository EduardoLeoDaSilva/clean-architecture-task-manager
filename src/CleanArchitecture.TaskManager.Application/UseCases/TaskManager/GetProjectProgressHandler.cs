using CleanArchitecture.TaskManager.Application.UseCases.TaskManager.Queries;
using CleanArchitecture.TaskManager.Domain.Repositories;
using MediatR;

namespace CleanArchitecture.TaskManager.Application.UseCases.TaskManager
{

    public class GetProjectProgressHandler : IRequestHandler<GetProjectsProgressQuery>
    {
        private readonly IProjectRepository _projectRepository;

        public GetProjectProgressHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public Task Handle(GetProjectsProgressQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
