using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Model
{
    class AboutMod
    {
        // Khai báo biến
        protected string tendangnhap { get; set; }
        // Hàm dựng
        public AboutMod(string _tendangnhap)
        {
            this.tendangnhap = _tendangnhap;
        }
        // Lấy thông tin tài khoản
        public DataTable LayThongTinTaiKhoan()
        {
            DataTable dt ;
            string sql = string.Format("SELECT * FROM nhanvien WHERE msnv IN (" +
                "SELECT masonhanvien FROM thongtindangnhap WHERE tendangnhap = '{0}'" +
                ") ", tendangnhap);
            dt = Model.Connection.FillDataTable(sql);
            Console.WriteLine(sql);
            return dt;
        }
        
       
    }
}
