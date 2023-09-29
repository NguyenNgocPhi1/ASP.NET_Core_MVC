using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web_MVC_Core.Models;
using Web_MVC_Core.Models.Autthentication;
using Web_MVC_Core.ViewModels;
using X.PagedList;

namespace Web_MVC_Core.Controllers
{
    public class HomeController : Controller
    {
        QLBanVaLiContext db = new QLBanVaLiContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Authentication]
        public IActionResult Index(int? page)
        {
            int pageSize = 12;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstsanpham = db.TDanhMucSps.AsNoTracking().OrderBy(x => x.TenSp);
            PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }
        [Authentication]
        public IActionResult SanPhamTheoLoai(string maloai,int? page)
        {
            
            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstsanpham = db.TDanhMucSps.AsNoTracking()
                .Where(x => x.MaLoai == maloai).OrderBy(x => x.TenSp);

            PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(lstsanpham, pageNumber, pageSize);
            ViewBag.maloai = maloai;
            return View(lst);
        }

        public IActionResult ProductDetail(string masp)
        {
            var sanPham = db.TDanhMucSps.SingleOrDefault(x => x.MaSp == masp);
            var anhSanPham = db.TAnhSps.Where(x => x.MaSp == masp).ToList();
            var homeProductDetailViewModel = new HomeProductDetailViewModel { danhMucSp = sanPham, anhSps = anhSanPham };
            return View(homeProductDetailViewModel);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
