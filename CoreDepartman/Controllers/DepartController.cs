using CoreDepartman.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDepartman.Controllers
{
    public class DepartController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Departmans.ToList();
            return View(degerler);
        }
    }
}
