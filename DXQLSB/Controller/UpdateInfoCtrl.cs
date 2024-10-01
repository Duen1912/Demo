using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Controller
{
    class UpdateInfoCtrl
    {
        public static string CapNhatThongTinTaiKhoan(string _hoten, int _gioitinh, string _diachi, int _msnv)
        {
            try
            {
                Model.UpdateInfoMod updateInfo = new Model.UpdateInfoMod(_hoten, _gioitinh, _diachi, _msnv);
                return updateInfo.CapNhatThongTinTaiKhoan();
            }
            catch { return ""; }
        }
    }
}
