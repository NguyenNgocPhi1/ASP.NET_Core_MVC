using EStoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EStoreWeb.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationContext db;

        public HomeController(ApplicationContext _db)
        {
            db = _db;
        }

        public IActionResult Index(int? page)
        {
            int PageSize = 5;
            int PageIndex;
            PageIndex = page == null ? 1 : (int)page;
            var lstProduct = db.Products.Include(x => x.Category).ToList();
            var pagecount = lstProduct.Count() / PageSize + (lstProduct.Count() % PageSize > 0 ? 1 : 0);
            ViewBag.pageSum = pagecount;
            ViewBag.PageIndex = PageIndex;
            return View(lstProduct.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList());
        }
        public IActionResult Detail(int id)
        {
            var obj = db.Products.Find(id);
            ViewBag.lst = db.Products.Where(x => x.CategoryId == obj.CategoryId && x.Id != obj.Id).ToList();
            if (obj == null)
                return NotFound();
            return View(obj);
        }
        
    }
}
