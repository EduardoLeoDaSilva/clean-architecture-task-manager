using AutoMapper;
using CleanArchitecture.TaskManager.Application.DTOs;
using CleanArchitecture.TaskManager.Application.Services;
using CleanArchitecture.TaskManager.Application.UseCases.TaskManager.Commands;
using CleanArchitecture.TaskManager.Application.UseCases.TaskManager.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly INotificationService _notificationService;

        public ProjectController(IMediator mediator, IMapper mapper, INotificationService notificationService)
        {
            _mediator = mediator;
            _mapper = mapper;
            _notificationService = notificationService;
        }

        [HttpPost]
        public IActionResult CreateProject([FromBody]ProjectDTO project)
        {

            var createProjectCommand = _mapper.Map<ProjectDTO, CreateProjectCommand>(project);
            var isCommandValid = createProjectCommand.Validate();
            if (!isCommandValid.Success)
                return BadRequest(isCommandValid.Message);

            _mediator.Send(createProjectCommand);

            if (!_notificationService.GetFinalNotification().Success)
                return BadRequest(_notificationService.GetFinalNotification().Message);

            return Ok();

        }

        [HttpPut]
        public IActionResult UpdateProject([FromBody]ProjectDTO project)
        {
            var updatecreateProjectCommand = _mapper.Map<ProjectDTO, UpdateProjectCommand>(project);
            var isCommandValid = updatecreateProjectCommand.Validate();
            if (!isCommandValid.Success)
                return BadRequest(isCommandValid.Message);

            _mediator.Send(updatecreateProjectCommand);

            if (!_notificationService.GetFinalNotification().Success)
                return BadRequest(_notificationService.GetFinalNotification().Message);

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteProject([FromRoute]Guid id)
        {
            var deleteProjectCommand = _mapper.Map<Guid, DeleteProjectCommand>(id);
            var isCommandValid = deleteProjectCommand.Validate();
            if (!isCommandValid.Success)
                return BadRequest(isCommandValid.Message);

            _mediator.Send(deleteProjectCommand);

            if (!_notificationService.GetFinalNotification().Success)
                return BadRequest(_notificationService.GetFinalNotification().Message);

            return Ok();
        }

        [HttpGet("progress")]
        public async Task<IActionResult> GetProjectProgressAsync([FromRoute]Guid id)
        {
            var getProjectsProgress = _mapper.Map<Guid, GetProjectsProgressQuery>(id);
            var isCommandValid = getProjectsProgress.Validate();
            if (!isCommandValid.Success)
                return BadRequest(isCommandValid.Message);

            await _mediator.Send(getProjectsProgress);

            if (!_notificationService.GetFinalNotification().Success)
                return BadRequest(_notificationService.GetFinalNotification().Message);

            return Ok(_notificationService.GetFinalNotification().Data);
        }
    }
}
