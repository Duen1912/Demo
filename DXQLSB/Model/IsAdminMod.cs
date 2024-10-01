using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Model
{
    class IsAdminMod
    {
        // Khai báo biến
        protected string tendangnhap { get; set; }
        // Khởi tạo hàm dựng 2 đối số dùng kiểm tra đăng nhập
        public IsAdminMod(string _tendangnhap)
        {
            this.tendangnhap = _tendangnhap;        
        }

        // Kiểm tra đăng nhập
        public string KiemTraAdmin()
        {
            string isAdmin = "";
            string[] para = new string[1] { "@tendangnhap" };
            object[] value = new object[1] { tendangnhap};
            isAdmin = Model.Connection.ExcuteScalar("spCheckIsAdmin", System.Data.CommandType.StoredProcedure, para, value);
            Console.WriteLine(isAdmin);
            return isAdmin;
        }
    }
}
