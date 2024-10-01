using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Controller
{
    class KichHoatTaiKhoanCtrl
    {
        public static DataTable LayThongTinTaiKhoanNhanVien(int _msnv)
        {
            DataTable dt = null;
            try
            {
                Model.KichHoatTaiKhoanMod khtk = new Model.KichHoatTaiKhoanMod(_msnv);
                dt = khtk.LayThongTinTaiKhoanNhanVien();
                return dt;
            }
            catch { return dt; }
        }

        public static string KichHoatTaiKhoan(int _msnv)
        {
            try
            {
                Model.KichHoatTaiKhoanMod khtk = new Model.KichHoatTaiKhoanMod(_msnv);
                return khtk.KichHoatTaiKhoan();
            }
            catch { return ""; }
        }

        public static string KhoaTaiKhoan(int _msnv)
        {
            try
            {
                Model.KichHoatTaiKhoanMod khtk = new Model.KichHoatTaiKhoanMod(_msnv);
                return khtk.KhoaTaiKhoan();
            }
            catch { return ""; }
        }
    }
}
