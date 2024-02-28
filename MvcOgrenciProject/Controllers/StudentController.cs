using Microsoft.AspNetCore.Mvc;

namespace MvcOgrenciProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
