using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Controller
{
    class TaoTaiKhoanCtrl
    {
        public static string KiemTra(int _msnv)
        {
            try
            {
                Model.TaoTaiKhoanMod taotaikhoan = new Model.TaoTaiKhoanMod(_msnv);
                return taotaikhoan.KiemTra();
            }
            catch { return ""; }
        }
        public static string KiemTraTonTaiTaiKhoan(int _msnv)
        {
            try
            {
                Model.TaoTaiKhoanMod taotaikhoan = new Model.TaoTaiKhoanMod(_msnv);
                return taotaikhoan.KiemTraTonTaiTaiKhoan();
            }
            catch { return ""; }
        }
        public static string KiemTraTrungTenDangNhap(string _tendangnhap)
        {
            try
            {
                Model.TaoTaiKhoanMod taotaikhoan = new Model.TaoTaiKhoanMod(_tendangnhap);
                return taotaikhoan.KiemTraTrungTenDangNhap();
            }
            catch { return ""; }
        }
        public static string ThemTaiKhoan(int _msnv, string _matkhau, string _tendangnhap)
        {
            try
            {
                
                Model.TaoTaiKhoanMod taotaikhoan = new Model.TaoTaiKhoanMod(_msnv,_matkhau,_tendangnhap);
                return taotaikhoan.ThemTaiKhoan();
            }
            catch { return ""; }
        }
    }
}
