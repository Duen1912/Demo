using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Controller
{
    class DatDichVuCtrl
    {
        public static string ThemDichVuVaoSan(int _masan, int _madichvu, string _tensanpham, int _dongia, 
            int _soluong, int _thanhtien)
        {
            try
            {
                Model.DatDichVuMod ddv = new Model.DatDichVuMod(_masan, _madichvu, _tensanpham,
                    _dongia, _soluong, _thanhtien);
                return ddv.ThemDichVuVaoSan();
            }
            catch { return ""; }
        }
    }
}
