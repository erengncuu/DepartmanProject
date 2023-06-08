using CoreDepartman.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CoreDepartman.Controllers
{
    public class PersonController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var deger = c.Personels.Include(x=>x.Departman).ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult NewPerson() 
        {   
            List<SelectListItem> degerler =(from x in c.Departmans.ToList() select new SelectListItem
                                                                                        {
                                                                                         Text=x.DepartmanName,
                                                                                         Value=x.Id.ToString()
                                                                                         }).ToList();
            ViewBag.Dgr = degerler;
            return View();
        }
      
        [HttpPost]
        public IActionResult NewPerson(Personel p)
        {
            var per = c.Departmans.Where(x => x.Id == p.Departman.Id).FirstOrDefault();
            p.Departman = per;
            c.Personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
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
