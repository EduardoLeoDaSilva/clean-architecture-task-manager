using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.TaskManager.WebApp.Controllers
{
    public class BaseController : Controller
    {
        private readonly INotificationService _notificationService;
        public BaseController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
    }
}
