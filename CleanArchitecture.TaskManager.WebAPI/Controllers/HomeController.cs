using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.TaskManager.WebAPI
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
