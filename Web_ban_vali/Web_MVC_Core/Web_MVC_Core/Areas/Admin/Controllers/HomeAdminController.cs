using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Web_MVC_Core.Models;
using X.PagedList;

namespace Web_MVC_Core.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeadmin")]
    public class HomeAdminController : Controller
    {
        QLBanVaLiContext db = new QLBanVaLiContext();
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeAdminController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
       

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("danhmucsanpham")]
        public IActionResult DanhMucSanPham(int? page)
        {
            int pageSize = 12;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstsanpham = db.TDanhMucSps.AsNoTracking().OrderBy(x => x.TenSp);
            PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }
        [Route("Create")]
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.MaChatLieu = new SelectList(db.TChatLieus.ToList(), "MaChatLieu", "ChatLieu");
            ViewBag.MaHangSx = new SelectList(db.THangSx.ToList(), "MaHangSx", "HangSx");
            ViewBag.MaNuocSx = new SelectList(db.TQuocGia.ToList(), "MaNuoc", "TenNuoc");
            ViewBag.MaLoai = new SelectList(db.TLoaiSps.ToList(), "MaLoai", "Loai");
            ViewBag.MaDt = new SelectList(db.TLoaiDts.ToList(), "MaDt", "TenLoai");
            return View();
        }
        [Route("Create")]
        [HttpPost]
        public IActionResult Create(TDanhMucSp sanpham, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    // Xu ly upload
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName); // tạo tên file cần lưu
                    string path = Path.Combine(_hostingEnvironment.WebRootPath, @"1LayoutOgani/ProductsImg/Images");
                    file.CopyTo(new FileStream(Path.Combine(path, filename), FileMode.Create));// sao chép lên server
                    sanpham.AnhDaiDien = @"1LayoutOgani/ProductsImg/Images/" + filename;
                }
                db.TDanhMucSps.Add(sanpham);
                db.SaveChanges();
                return RedirectToAction("DanhMucSanPham");
            }
            
            return View();
        }
        [Route("Edit")]
        [HttpGet]
        public IActionResult Edit(string maSanPham)
        {
            ViewBag.MaChatLieu = new SelectList(db.TChatLieus.ToList(), "MaChatLieu", "ChatLieu");
            ViewBag.MaHangSx = new SelectList(db.THangSx.ToList(), "MaHangSx", "HangSx");
            ViewBag.MaNuocSx = new SelectList(db.TQuocGia.ToList(), "MaNuoc", "TenNuoc");
            ViewBag.MaLoai = new SelectList(db.TLoaiSps.ToList(), "MaLoai", "Loai");
            ViewBag.MaDt = new SelectList(db.TLoaiDts.ToList(), "MaDt", "TenLoai");
            var sp = db.TDanhMucSps.Find(maSanPham);
            if (sp == null)
                return NotFound();
            return View(sp);
        }
        [Route("Edit")]
        [HttpPost]
        public IActionResult Edit(TDanhMucSp sanpham, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    // Xu ly upload
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName); // tạo tên file cần lưu
                    string path = Path.Combine(_hostingEnvironment.WebRootPath, @"1LayoutOgani/ProductsImg/Images");
                    using (var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                    {
                        file.CopyTo(filestream);// sao chép lên server

                    }
                    // xoa hinh cu cua san pham
                    if (!String.IsNullOrEmpty(sanpham.AnhDaiDien))
                    {
                        var oldFile = Path.Combine(_hostingEnvironment.WebRootPath, sanpham.AnhDaiDien);
                        if (System.IO.File.Exists(oldFile))
                        {
                            System.IO.File.Delete(oldFile);
                        }
                    }
                    sanpham.AnhDaiDien = @"1LayoutOgani/ProductsImg/Images/" + filename;
                }
                db.Update<TDanhMucSp>(sanpham);
                db.SaveChanges();
                return RedirectToAction("DanhMucSanPham", "HomeAdmin");
            }
            return View();
        }
        [Route("XoaSanPham")]
        [HttpGet]
        public IActionResult Delete(string maSanPham)
        {

            TempData["Message"] = "";
                var chiTietSP = db.TChiTietSanPhams.Where(x => x.MaSp == maSanPham).ToList();
                if(chiTietSP.Count() > 0)
                {
                TempData["Message"] = "Không xóa được sản phẩm này";
                    return RedirectToAction("DanhMucSanPham","HomeAdmin");
                }

            var anhSP = db.TAnhSps.Where(x => x.MaSp == maSanPham);
            if (anhSP.Any()) db.RemoveRange(anhSP);
            db.Remove(db.TDanhMucSps.Find(maSanPham));
            db.SaveChanges();
            TempData["Message"] = "Sản phẩm này đã được xóa";
            return RedirectToAction("DanhMucSanPham", "HomeAdmin");
        }
    }
}
