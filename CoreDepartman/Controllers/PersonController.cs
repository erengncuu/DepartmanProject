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
        public IActionResult DeletePerson(int id)
        {
            var per = c.Personels.Find(id);
            c.Personels.Remove(per);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult EditPerson(int id)
        {
            var person = c.Personels.Find(id);
            return View("EditPerson",person);
        }
        public IActionResult UpdatePerson(Personel p)
        {
            var per = c.Personels.Find(p.PerId);
            per.FirstName = p.FirstName;
            per.LastName = p.LastName;
            per.City = p.City;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
