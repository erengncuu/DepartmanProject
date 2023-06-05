using Microsoft.AspNetCore.Mvc;

namespace CoreDepartman.Controllers
{
    public class DepartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
