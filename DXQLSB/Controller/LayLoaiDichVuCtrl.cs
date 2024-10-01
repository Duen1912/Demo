using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Controller
{
    class LayLoaiDichVuCtrl
    {
        public static DataTable LayThongTinLoaiDichVu()
        {
            DataTable dt = null;
            try
            {
                Model.LayLoaiDichVuMod layiDichVu = new Model.LayLoaiDichVuMod();
                dt = layiDichVu.LayThongTinLoaiDichVu();
                return dt;
            }
            catch { return dt; }
        }

        public static DataTable LayThongTinSanPham(int _madichvu)
        {
            DataTable dt = null;
            try
            {
                Model.LayLoaiDichVuMod layiSanPham = new Model.LayLoaiDichVuMod(_madichvu);
                dt = layiSanPham.LayThongTinSanPham();
                return dt;
            }
            catch { return dt; }
        }
    }
}
