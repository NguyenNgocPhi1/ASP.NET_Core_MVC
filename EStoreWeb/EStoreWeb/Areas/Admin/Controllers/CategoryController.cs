using EStoreWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStoreWeb.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CategoryController : Controller
    {
        private readonly ApplicationContext db;
        public CategoryController(ApplicationContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var dsCategory = db.Categories.ToList();
            return View(dsCategory);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid) // kiem tra hop le
            {
                //them obj vao table category
                db.Categories.Add(category);
                db.SaveChanges();
                TempData["success"] = "Category inserted success";
                return RedirectToAction("Index");
            }
            return View();
        }
        
        public IActionResult Edit(int id)
        {
            //truy van category theo id
            var obj1 = db.Categories.Find(id);
            //var obj2 = db.Categories.SingleOrDefault(x => x.CategoryId == id);
            //var obj3 = db.Categories.Where(w => w.CategoryId == id).SingleOrDefault();
            if (obj1 == null)
                return NotFound();
            //tra ve view de edit
            return View(obj1);
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid) // kiem tra hop le
            {
                //cap nhap obj vao table category
                db.Update<Category>(category);
                db.SaveChanges();
                TempData["success"] = "Category updated success";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            //truy van the loai theo id
            var obj = db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            //tra ve view edit
            return View(obj);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            //truy van the loai theo id
            var obj = db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            //xoá
            db.Categories.Remove(obj);
            db.SaveChanges();
            TempData["error"] = "Category deleted success";
            return RedirectToAction("Index");
        }
    }
}
