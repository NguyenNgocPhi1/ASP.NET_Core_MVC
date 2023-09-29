using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_MVC_Core.Models;
using Web_MVC_Core.Repository;

namespace Web_MVC_Core.ViewComponents
{
    public class LoaiSpMenuViewComponent : ViewComponent
    {
        private readonly ILoaiSPRepository _loaiSp;
        public LoaiSpMenuViewComponent(ILoaiSPRepository loaiSPRepository)
        {
            _loaiSp = loaiSPRepository;
        }
        public IViewComponentResult Invoke()
        {
            var loaiSp = _loaiSp.GetAllLoaiSp().OrderBy(x => x.Loai);
            return View(loaiSp);
        }
    }
}
