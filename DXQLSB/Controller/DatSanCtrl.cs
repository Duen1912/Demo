using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Controller
{
    class DatSanCtrl
    {
        public static string ThemThongTinNguoiDatSan(string _hotenkhachhang, string _cmnd, string _sdt, int _masan, int _dongia,
            string _thoigian, string _nhanvienphutrach)
            {
                try
                {
                    Model.DatSanMod ds = new Model.DatSanMod(_hotenkhachhang, _cmnd, _sdt, 
                        _masan, _dongia, _thoigian, _nhanvienphutrach);
                    return ds.ThemThongTinNguoiDatSan();
                }
                catch { return ""; }
            }
    }
}
