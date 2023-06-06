using CoreDepartman.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDepartman.Controllers
{
    public class PersonController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var deger = c.Personels.ToList();
            return View(deger);
        }
    }
}
