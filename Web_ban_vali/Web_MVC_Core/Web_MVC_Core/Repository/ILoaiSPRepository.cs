using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_MVC_Core.Models;

namespace Web_MVC_Core.Repository
{
    public interface ILoaiSPRepository
    {
        TLoaiSp Add(TLoaiSp loaiSp);
        TLoaiSp Update(TLoaiSp loaiSp);
        TLoaiSp Delete(String maloaiSp);
        TLoaiSp GetLoaiSp(TLoaiSp maloaiSp);
        IEnumerable<TLoaiSp> GetAllLoaiSp();


    }
}
