using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Controller
{
    class AboutCtrl
    {
        public static DataTable LayThongTinTaiKhoan(string _tendangnhap)
        {
            DataTable dt = null;
            try
            {
                Model.AboutMod abtMod = new Model.AboutMod(_tendangnhap);
                dt = abtMod.LayThongTinTaiKhoan();
                return dt;
            }
            catch { return dt; }
        }
    }
}
