using System;
using DevExpress.Xpo;

namespace DXQLSB.Model
{

    public class UpdateInfoMod
    {
        // Khai báo biến
        protected string hoten { get; set; }
        protected int gioitinh { get; set; }
        protected string diachi { get; set; }
        protected int masonhanvien { get; set; }
        // Hàm dựng
        public UpdateInfoMod(string _hoten, int _gioitinh, string _diachi, int _msnv )
        {
            this.hoten = _hoten;
            this.gioitinh = _gioitinh;
            this.diachi = _diachi;
            this.masonhanvien = _msnv;
        }
        // Lấy thông tin tài khoản
        public string CapNhatThongTinTaiKhoan()
        {
            string str = "";
            string[] para = new string[4] { "@hotenmoi", "@gioitinhmoi", "@diachimoi", "@masonhanvien" };
            object[] value = new object[4] { hoten, gioitinh, diachi, masonhanvien };
            str = Model.Connection.Excute_Sql("spUpdate_NhanVien", System.Data.CommandType.StoredProcedure, para, value).ToString();
            Console.WriteLine(str);
            return str;
        }
    }

}