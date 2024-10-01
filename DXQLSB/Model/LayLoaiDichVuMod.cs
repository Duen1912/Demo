using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Model
{
    class LayLoaiDichVuMod
    {
        // Khai báo biến
        protected int madichvu { get; set; }
        // Hàm dựng
        public LayLoaiDichVuMod(int _madichvu)
        {
            this.madichvu = _madichvu;
        }

        public LayLoaiDichVuMod()
        {

        }
        // Lấy thông tin san
        /*public DataTable LayThongTinLoaiDichVu()
        {
            DataTable dt;
            string loaisan_operator = ">";
            string dongia_operator = ">";
            if (loaisan != -1)
            {
                loaisan_operator = "=";
            }
            if (dongia != -1)
            {
                dongia_operator = "=";
            }
            string sql = string.Format("SELECT * FROM san WHERE loaisan" + loaisan_operator + "{0} AND dongia" + dongia_operator + "{1} AND isdangdat = 'false' ", loaisan, dongia);
            dt = Model.Connection.FillDataTable(sql);
            Console.WriteLine(sql);
            return dt;
        }*/

        public DataTable LayThongTinLoaiDichVu()
        {
            DataTable dt;
            string sql = string.Format("SELECT * FROM loaidichvu ORDER BY madichvu");
            dt = Model.Connection.FillDataTable(sql);
            Console.WriteLine(sql);
            return dt;
        }

        public DataTable LayThongTinSanPham()
        {
            DataTable dt;
            string sql = string.Format("SELECT * FROM dichvu WHERE madichvu = {0}", madichvu);
            dt = Model.Connection.FillDataTable(sql);
            Console.WriteLine(sql);
            return dt;
        }

    }
}
