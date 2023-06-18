using CleanArchitecture.TaskManager.Application.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.TaskManager.WebApp.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IMediator _mediator;
        protected readonly INotificationService _notificationService;
        public BaseController(INotificationService notificationService, IMediator mediator)
        {
            _notificationService = notificationService;
            _mediator = mediator;
        }
    }
}
