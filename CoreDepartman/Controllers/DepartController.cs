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
        [HttpGet]
        public IActionResult NewDepartman() 
        {
        return View();
        }
        [HttpPost]
        public IActionResult NewDepartman(Departman d)
        {
            return View();
        }
    }
}
