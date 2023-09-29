using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EStoreWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace EStoreWeb.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class ProductController : Controller
    {
        private readonly ApplicationContext db;
        private readonly IHostingEnvironment hostingEnvironment;

        public ProductController(ApplicationContext _db,IHostingEnvironment _host)
        {
            db = _db;
            hostingEnvironment = _host;
        }

        public IActionResult Index(int ?page)
        {
            int PageSize = 5;
            int PageIndex;
            PageIndex = page == null ? 1 : (int)page;
            var lstProduct = db.Products.Include(x=>x.Category).ToList();
            var pagecount = lstProduct.Count() / PageSize + (lstProduct.Count() % PageSize > 0 ? 1 : 0);
            ViewBag.pageSum = pagecount;
            ViewBag.PageIndex = PageIndex;
            return View(lstProduct.Skip((PageIndex-1)*PageSize).Take(PageSize).ToList());
        }
        public IActionResult Create()
        {
            // truyen danh sach the loai cho View de sinh ra dieu khien DropDown List 
            ViewBag.lstCategory = db.Categories.Select(x => new SelectListItem { Value = x.CategoryId.ToString(), Text = x.Name });
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product c,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    // Xu ly upload
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName); // tạo tên file cần lưu
                    string path = Path.Combine(hostingEnvironment.WebRootPath, @"Products/Imgs");
                    file.CopyTo(new FileStream(Path.Combine(path, filename), FileMode.Create));// sao chép lên server
                    c.ImageUrl = @"Products/Imgs/" + filename;
                }                                                                          
                // them c vao table 
                db.Products.Add(c);
                db.SaveChanges();
                TempData["success"] = "Category create success";
                return RedirectToAction("Index");
            }
            ViewBag.lstCategory = db.Categories.Select(x => new SelectListItem { Value = x.CategoryId.ToString(), Text = x.Name });
            return View();
        }
        public IActionResult Edit(int id)
        {
            ViewBag.lstCategory = db.Categories.Select(x => new SelectListItem { Value = x.CategoryId.ToString(), Text = x.Name });
            // Truy van category theo id
            var obj = db.Products.Find(id);
            if (obj == null)
                return NotFound();
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(Product c, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    // Xu ly upload
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName); // tạo tên file cần lưu
                    string path = Path.Combine(hostingEnvironment.WebRootPath, @"Products/Imgs");
                    using(var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                    {
                        file.CopyTo(filestream);// sao chép lên server

                    }
                    // xoa hinh cu cua san pham
                    if (!String.IsNullOrEmpty(c.ImageUrl))
                    {
                        var oldFile = Path.Combine(hostingEnvironment.WebRootPath, c.ImageUrl);
                        if (System.IO.File.Exists(oldFile))
                        {
                            System.IO.File.Delete(oldFile);
                        }
                    }
                    c.ImageUrl = @"Products/Imgs/" + filename;
                }
                // them c vao table 
                db.Update<Product>(c);
                db.SaveChanges();
                TempData["success"] = "Category Update success";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            ViewBag.lstCategory = db.Categories.Select(x => new SelectListItem { Value = x.CategoryId.ToString(), Text = x.Name });
            // Truy van category theo id
            var objproduct = db.Products.Find(id);
            if (objproduct == null)
                return NotFound();
            // xoa
            return View(objproduct);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            //truy van the loai theo id
            var objProduct = db.Products.Find(id);
            if (objProduct == null)
            {
                return NotFound();
            }
            if (!String.IsNullOrEmpty(objProduct.ImageUrl))
            {
                var oldFile = Path.Combine(hostingEnvironment.WebRootPath, objProduct.ImageUrl);
                if (System.IO.File.Exists(oldFile))
                {
                    System.IO.File.Delete(oldFile);
                }
            }
            //xoá
            db.Products.Remove(objProduct);
            db.SaveChanges();
            TempData["success"] = "Products deleted success";
            return RedirectToAction("Index");
        }
    }
}

