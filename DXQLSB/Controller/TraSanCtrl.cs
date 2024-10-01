using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Controller
{
    class TraSanCtrl
    {
        public static string LamTrongSan(int _masan)
        {
            try
            {
                Model.TraSanMod traSan= new Model.TraSanMod(_masan);
                return traSan.LamTrongSan();
            }
            catch { return ""; }
        }

        public static string ThanhToanSan(int _masan)
        {
            try
            {
                Model.TraSanMod traSan = new Model.TraSanMod(_masan);
                return traSan.ThanhToanSan();
            }
            catch { return ""; }
        }

        public static string ThanhToanDichVu(int _masan)
        {
            try
            {
                Model.TraSanMod traSan = new Model.TraSanMod(_masan);
                return traSan.ThanhToanDichVu();
            }
            catch { return ""; }
        }

        public static string TaoHoaDon(string _tensan, int _masan, int _tongtiensan, int _tongtiendichvu,
            int _tongcong, string _ngaytao, string _nguoitao)
        {
            try
            {
                Model.TraSanMod traSan = new Model.TraSanMod(_tensan, _masan, _tongtiensan, _tongtiendichvu, 
                    _tongcong, _ngaytao, _nguoitao);
                return traSan.TaoHoaDon();
            }
            catch { return ""; }
        }
    }
}
