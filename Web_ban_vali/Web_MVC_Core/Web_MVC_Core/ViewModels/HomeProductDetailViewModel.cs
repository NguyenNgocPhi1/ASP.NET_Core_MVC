using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_MVC_Core.Models;

namespace Web_MVC_Core.ViewModels
{
    public class HomeProductDetailViewModel
    {
        public TDanhMucSp danhMucSp { get; set; }
        public List<TAnhSp> anhSps { get; set; }

    }
}
