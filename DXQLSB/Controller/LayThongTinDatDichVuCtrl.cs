using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Controller
{
    class LayThongTinDatDichVuCtrl
    {
        public static DataTable LayThongTinDatDichVu(int _masan)
        {
            DataTable dt = null;
            try
            {
                Model.LayThongTinDatDichVuMod layDatDichVu = new Model.LayThongTinDatDichVuMod(_masan);
                dt = layDatDichVu.LayThongTinDatDichVu();
                return dt;
            }
            catch { return dt; }
        }
    }
}
