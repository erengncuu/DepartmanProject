using CoreDepartman.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoreDepartman.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Login(Admin a)
        {
            var infos = c.Admins.FirstOrDefault(x => x.UserName == a.UserName && x.password == a.password);
            if (infos != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,a.UserName)
                };
                var useridentity=new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","person");
            }
            return View();
        }
    }
}
