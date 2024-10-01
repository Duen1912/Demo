using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Controller
{
    class DoiMatKhauCtrl
    {
        public static string DoiMatKhau(string _tendangnhap, string _matkhaumoi)
        {
            try
            {
                Model.DoiMatKhauMod dmk = new Model.DoiMatKhauMod(_tendangnhap, _matkhaumoi);
                return dmk.DoiMatKhau();
            }
            catch { return ""; }
        }
    }
}
