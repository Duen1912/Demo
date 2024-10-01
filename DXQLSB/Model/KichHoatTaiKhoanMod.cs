using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Model
{
    class KichHoatTaiKhoanMod
    {
        // Khai báo biến
        protected int msnv { get; set; }
        // Khởi tạo hàm dựng 2 đối số dùng kiểm tra đăng nhập
        public KichHoatTaiKhoanMod(int _msnv)
        {
            this.msnv = _msnv;
        }

        public DataTable LayThongTinTaiKhoanNhanVien()
        {
            DataTable dt;
            string sql = string.Format("SELECT * FROM thongtindangnhap, nhanvien WHERE thongtindangnhap.masonhanvien = {0} and nhanvien.msnv = {0}", msnv);
            dt = Model.Connection.FillDataTable(sql);
            Console.WriteLine(sql);
            return dt;
        }

        public string KichHoatTaiKhoan()
        {
            string kichhoat = "";
            string[] para = new string[1] { "@msnv" };
            object[] value = new object[1] { msnv };
            kichhoat = Model.Connection.Excute_Sql("spKichHoatTaiKhoan", System.Data.CommandType.StoredProcedure, para, value).ToString();
            Console.WriteLine(kichhoat);
            return kichhoat;
        }

        public string KhoaTaiKhoan()
        {
            string kichhoat = "";
            string[] para = new string[1] { "@msnv" };
            object[] value = new object[1] { msnv };
            kichhoat = Model.Connection.Excute_Sql("spKhoaTaiKhoan", System.Data.CommandType.StoredProcedure, para, value).ToString();
            Console.WriteLine(kichhoat);
            return kichhoat;
        }
    }
}
