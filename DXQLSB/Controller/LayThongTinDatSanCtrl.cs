using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Controller
{
    class LayThongTinDatSanCtrl
    {
        public static DataTable LayThongTinDatSan(int _masan)
        {
            DataTable dt = null;
            try
            {
                Model.LayThongTinDatSanMod layDatSan = new Model.LayThongTinDatSanMod(_masan);
                dt = layDatSan.LayThongTinDatSan();
                return dt;
            }
            catch { return dt; }
        }
    }
}
