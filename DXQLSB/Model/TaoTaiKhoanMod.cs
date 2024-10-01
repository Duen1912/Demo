using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Model
{
    class TaoTaiKhoanMod
    {
        // Khai báo biến
        protected int msnv { get; set; }
        protected string tendangnhap { get; set; }
        protected string matkhau { get; set; }
        // Khởi tạo hàm dựng 2 đối số dùng kiểm tra đăng nhập
        public TaoTaiKhoanMod(int _msnv)
        {
            this.msnv = _msnv;
        }
        public TaoTaiKhoanMod(string _tendangnhap)
        {
            this.tendangnhap = _tendangnhap;
        }
        public TaoTaiKhoanMod(int _msnv, string _matkhau, string _tendangnhap)
        {
            this.msnv = _msnv;
            this.matkhau = _matkhau;
            this.tendangnhap = _tendangnhap;
        }
        // Kiểm tra mã số nhân viên có nằm trong bảng nhân viên hay không
        public string KiemTra()
        {
            string isNhanVien = "";
            string[] para = new string[1] { "@msnv" };
            object[] value = new object[1] { msnv };
            isNhanVien = Model.Connection.ExcuteScalar("spCheckNhanVien", System.Data.CommandType.StoredProcedure, para, value);
            Console.WriteLine(isNhanVien);
            return isNhanVien;
        }
        public string KiemTraTonTaiTaiKhoan()
        {
            string isNhanVien = "";
            string[] para = new string[1] { "@msnv" };
            object[] value = new object[1] { msnv };
            isNhanVien = Model.Connection.ExcuteScalar("spCheckTonTaiTaiKhoan", System.Data.CommandType.StoredProcedure, para, value);
            Console.WriteLine(isNhanVien);
            return isNhanVien;
        }
        public string KiemTraTrungTenDangNhap()
        {
            string istrunglap = "";
            string[] para = new string[1] { "@tendangnhap" };
            object[] value = new object[1] { tendangnhap };
            istrunglap = Model.Connection.ExcuteScalar("spCheckTrungTenDangNhap", System.Data.CommandType.StoredProcedure, para, value);
            Console.WriteLine(istrunglap);
            return istrunglap;
        }
        public string ThemTaiKhoan()
        {
            string themtaikhoan = "";
            string[] para = new string[3] { "@tendangnhap", "@matkhau", "@masonhanvien" };
            object[] value = new object[3] { tendangnhap, matkhau, msnv };
            themtaikhoan = Model.Connection.Excute_Sql("spInsert_ThongTinDangNhap", System.Data.CommandType.StoredProcedure, para, value).ToString();
            Console.WriteLine(matkhau);
            return themtaikhoan;
        }
    }
}
