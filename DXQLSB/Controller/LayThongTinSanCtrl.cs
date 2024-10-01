using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Controller
{
    class LayThongTinSanCtrl
    {
        public static DataTable LayThongTinSan(int _loaisan, int _giasan, int _trangthai)
        {
            DataTable dt = null;
            try
            {
                Model.LayThongTinSanMod laySan = new Model.LayThongTinSanMod(_loaisan, _giasan, _trangthai);
                dt = laySan.LayThongTinSan();
                return dt;
            }
            catch { return dt; }
        }

        public static DataTable LayThongTinLoaiSan()
        {
            DataTable dt = null;
            try
            {
                Model.LayThongTinSanMod laySan = new Model.LayThongTinSanMod();
                dt = laySan.LayThongTinLoaiSan();
                return dt;
            }
            catch { return dt; }
        }

        public static DataTable LayThongTinDonGia()
        {
            DataTable dt = null;
            try
            {
                Model.LayThongTinSanMod laySan = new Model.LayThongTinSanMod();
                dt = laySan.LayThongTinDonGia();
                return dt;
            }
            catch { return dt; }
        }

        public static DataTable LayThongTinSanDeDat(int _id)
        {
            DataTable dt = null;
            try
            {
                Model.LayThongTinSanMod laySan = new Model.LayThongTinSanMod(_id);
                dt = laySan.LayThongTinSanDeDat();
               
                return dt;
            }
            catch { return dt; }
        }

        public static DataTable LayThongTinSanDaDat()
        {
            DataTable dt = null;
            try
            {
                Model.LayThongTinSanMod laySan = new Model.LayThongTinSanMod();
                dt = laySan.LayThongTinSanDaDat();

                return dt;
            }
            catch { return dt; }
        }
    }
}
