using CleanArchitecture.TaskManager.Application.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.WebApp.Controllers
{
    public class UserController : BaseController
    {

        public UserController(INotificationService notificationService, IMediator mediator) 
            : base(notificationService, mediator)
        {
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
