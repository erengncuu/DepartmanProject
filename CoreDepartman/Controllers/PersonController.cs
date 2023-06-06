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
        [HttpGet]
        public IActionResult NewPerson() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewPerson(Personel p)
        {
            return View();
        }
    }
}
