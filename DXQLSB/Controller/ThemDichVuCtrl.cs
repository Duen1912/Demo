using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Controller
{
    class ThemDichVuCtrl
    {
        public static string ThemDichVu(int madichvu, string _tensanpham, int _dongia)
        {
            try
            {
                Model.ThemDichVuMod themDV = new Model.ThemDichVuMod(madichvu, _tensanpham, _dongia);
                return themDV.ThemDichVu();
            }
            catch { return ""; }
        }
    }
}
