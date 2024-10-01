using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Model
{
    class LayThongTinSanMod
    {
        // Khai báo biến
        protected int loaisan { get; set; }
        protected int dongia { get; set; }
        protected int id { get; set; }
        protected int trangthai { get; set; }

        // Hàm dựng
        public LayThongTinSanMod(int _loaisan, int _dongia, int _trangthai)
        {
            this.loaisan = _loaisan;
            this.dongia = _dongia;
            this.trangthai = _trangthai;
        }

        public LayThongTinSanMod()
        {
            
        }

        public LayThongTinSanMod(int _id)
        {
            this.id = _id;
        }
        // Lấy thông tin san
        public DataTable LayThongTinSan()
        {
            DataTable dt;
            string loaisan_operator = ">";
            string dongia_operator = ">";
            if(loaisan != -1)
            {
                loaisan_operator = "=";
            }
            if(dongia != -1)
            {
                dongia_operator = "=";
            }

            string sql = string.Format("SELECT * FROM san WHERE loaisan" + loaisan_operator + "{0} AND dongia" + dongia_operator + "{1} AND isdangdat = 'false' ", loaisan, dongia);
            if (trangthai == 1)
            {
                sql = string.Format("SELECT * FROM san WHERE loaisan" + loaisan_operator + "{0} AND dongia" + dongia_operator + "{1} ", loaisan, dongia);
            }
            
            dt = Model.Connection.FillDataTable(sql);
            Console.WriteLine(sql);
            return dt;
        }

        public DataTable LayThongTinLoaiSan()
        {
            DataTable dt;
            string sql = string.Format("SELECT DISTINCT loaisan FROM san ORDER BY loaisan");
            dt = Model.Connection.FillDataTable(sql);
            Console.WriteLine(sql);
            return dt;
        }

        public DataTable LayThongTinDonGia()
        {
            DataTable dt;
            string sql = string.Format("SELECT DISTINCT dongia FROM san ORDER BY dongia");
            dt = Model.Connection.FillDataTable(sql);
            Console.WriteLine(sql);
            return dt;
        }

        public DataTable LayThongTinSanDeDat()
        {
            DataTable dt;
            string sql = string.Format("SELECT * FROM san WHERE id = {0}", id);
            dt = Model.Connection.FillDataTable(sql);
            Console.WriteLine(sql);
            return dt;
        }

        public DataTable LayThongTinSanDaDat()
        {
            DataTable dt;
            string sql = string.Format("SELECT * FROM san WHERE isdangdat = 1");
            dt = Model.Connection.FillDataTable(sql);
            Console.WriteLine(sql);
            return dt;
        }
    }
}
