using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Model
{
    class DatSanMod
    {
        // Khai báo biến
        protected string hotenkhachhang { get; set; }
        protected string cmnd { get; set; }
        protected string sdt { get; set; }
        protected int masan { get; set; }
        protected int dongia { get; set; }
        protected string thoigian { get; set; }
        protected string nhanvienphutrach { get; set; }
        // Khởi tạo hàm dựng 2 đối số dùng kiểm tra đăng nhập
        public DatSanMod(string _hotenkhachhang, string _cmnd, string _sdt, int _masan, int _dongia,
            string _thoigian, string _nhanvienphutrach)
        {
            this.hotenkhachhang = _hotenkhachhang;
            this.cmnd = _cmnd;
            this.sdt = _sdt;
            this.masan = _masan;
            this.dongia = _dongia;
            this.thoigian = _thoigian;
            this.nhanvienphutrach = _nhanvienphutrach;
        }

        // insert
        public string ThemThongTinNguoiDatSan()
        {
            int result ;
            string[] para = new string[7] { "@hotenkhachhang", "@cmnd" , "@sdt" ,
                "@masan" , "@dongia" , "@thoigian" , "@nhanvienphutrach" };
            object[] value = new object[7] { hotenkhachhang, cmnd, sdt,
                masan, dongia, thoigian, nhanvienphutrach };
            result = Model.Connection.Excute_Sql("spInsert_ThongTinDatSan", System.Data.CommandType.StoredProcedure, para, value);

            string sql = string.Format("UPDATE san SET isdangdat = 1 WHERE id = {0} ", masan);
            int result2 = Model.Connection.Excute_Sql(sql);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            return result.ToString();
        }

    }
}
