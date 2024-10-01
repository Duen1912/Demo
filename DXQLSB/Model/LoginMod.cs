using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Model
{
    class LoginMod
    {
        // Khai báo biến
        protected string tendangnhap { get; set; }
        protected string matkhau { get; set; }
        // Khai báo trạng thái tài khoản
        protected bool trangthai { get; set; }
        // Khởi tạo hàm dựng 2 đối số dùng kiểm tra đăng nhập
        public LoginMod(string _tendangnhap, string _matkhau)
        {
            this.tendangnhap = _tendangnhap;
            this.matkhau = _matkhau;
        }

        // Đổi mật khẩu tại tên đăng nhập
        public string KiemTraDangNhap()
        {
            string str = "";
            string[] para = new string[2] { "@tendangnhap", "@matkhau" };
            object[] value = new object[2] { tendangnhap, matkhau };
            str = Model.Connection.ExcuteScalar("spCheckDangNhap", CommandType.StoredProcedure, para, value);
            Console.WriteLine(str);
            return str;
        }
    }
}
