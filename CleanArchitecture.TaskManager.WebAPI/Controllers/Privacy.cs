using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.TaskManager.WebAPI.Controllers
{
    public class Privacy : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
