using Microsoft.AspNetCore.Mvc;

namespace MvcOgrenciProject.Views.Components
{
    public class NavbarOlcak : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
