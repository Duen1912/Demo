using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXQLSB.Model
{
    class DoiMatKhauMod
    {
        // Khai báo biến
        protected string tendangnhap { get; set; }
        protected string matkhaumoi { get; set; }

        // Khởi tạo hàm dựng 2 đối số dùng kiểm tra đăng nhập
        public DoiMatKhauMod(string _tendangnhap, string _matkhaumoi)
        {
            this.tendangnhap = _tendangnhap;
            this.matkhaumoi = _matkhaumoi;
        }

        // Đổi mật khẩu
        public string DoiMatKhau()
        {
            string str = "";
            string[] para = new string[2] { "@tendangnhap", "@matkhaumoi" };
            object[] value = new object[2] { tendangnhap, matkhaumoi };
            str = Model.Connection.Excute_Sql("spUpdate_MatKhau", System.Data.CommandType.StoredProcedure, para, value).ToString();
            Console.WriteLine(str);
            return str;
        }
    }
}
