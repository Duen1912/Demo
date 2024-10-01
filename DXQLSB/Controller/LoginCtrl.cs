using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Controller
{
    class LoginCtrl
    {
        public static string KiemTraDangNhap(string _tendangnhap, string _matkhau)
        {
            try
            {
                Model.LoginMod login = new Model.LoginMod(_tendangnhap, _matkhau);
                return login.KiemTraDangNhap();
            }
            catch   { return "";}
        }
        
        public static string KiemTraAdmin(string _tendangnhap)
        {
            try
            {
                Model.IsAdminMod isadm = new Model.IsAdminMod(_tendangnhap);
                return isadm.KiemTraAdmin();
            }
            catch { return ""; }
        }
    }
}
