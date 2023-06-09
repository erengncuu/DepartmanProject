using CoreDepartman.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDepartman.Controllers
{
    public class DepartController : Controller
    {
        Context c = new Context();
        [Authorize]
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
            c.Departmans.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
            
        }
        public IActionResult DeleteDepartman(int id) {
            var dep = c.Departmans.Find(id);
            c.Departmans.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartmanGetir(int id)
        {
            var depart = c.Departmans.Find(id);
            return View("departmanGetir",depart);
        }
        public IActionResult UpdateDepartman(Departman d)
        {
            var dep = c.Departmans.Find(d.Id);
            dep.DepartmanName = d.DepartmanName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DetailsStaff(int id)
        {
            var degerler = c.Personels.Where(x=>x.DepartmanId==id).ToList();
            return View(degerler);
        }
    }
}
