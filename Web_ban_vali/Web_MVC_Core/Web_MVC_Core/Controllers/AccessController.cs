using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_MVC_Core.Models;

namespace Web_MVC_Core.Controllers
{
    public class AccessController : Controller
    {
        QLBanVaLiContext db = new QLBanVaLiContext();
        [HttpGet]
        public IActionResult Login()
        {
            if(HttpContext.Session.GetString("UserName") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index","Home");
            }
            
        }
        public IActionResult Login(TUser user)
        {
            if(HttpContext.Session.GetString("UserName") == null)
            {
                var u = db.TUsers.Where(x => x.Username.Equals(user.Username) && x.Password.Equals(user.Password)).FirstOrDefault();
                var loaiuser = db.TUsers.Where(x => x.Username.Equals(user.Username)).Select(x => x.LoaiUser).FirstOrDefault();
                if(u != null && loaiuser.ToString() == "0")
                {
                    HttpContext.Session.SetString("UserName", u.Username.ToString());
                    return RedirectToAction("Index", "Home");
                }
                if(u != null && loaiuser.ToString() == "1")
                {
                    HttpContext.Session.SetString("UserName", u.Username.ToString());
                    return RedirectToAction("Index", "Admin");
                }
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("UserName");
            return RedirectToAction("Login", "Access");
        }
    }
}
