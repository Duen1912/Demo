using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Model
{
    class DatDichVuMod
    {
        // Khai báo biến
        protected int masan { get; set; }
        protected int madichvu { get; set; }
        protected string tensanpham { get; set; }
        protected int dongia { get; set; }
        protected int soluong { get; set; }
        protected int thanhtien { get; set; }
        // Hàm dựng
        // Hàm dựng
        public DatDichVuMod(int _masan, int _madichvu, string _tensanpham, int _dongia, int _soluong, int _thanhtien)
        {
            this.masan = _masan;
            this.madichvu = _madichvu;
            this.tensanpham = _tensanpham;
            this.dongia = _dongia;
            this.soluong = _soluong;
            this.thanhtien = _thanhtien;
        }

        // Insert thongtindatdichvu
        public string ThemDichVuVaoSan()
        {
            string str = "";
            string ngaytao = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
            string[] para = new string[7] { "@masan", "@madichvu", "@tensanpham", "@dongia", "@soluong", "@thanhtien","@ngaytao" };
            object[] value = new object[7] { masan, madichvu, tensanpham, dongia, soluong, thanhtien, ngaytao };
            str = Model.Connection.Excute_Sql("spInsert_ThongTinDatDichVu", System.Data.CommandType.StoredProcedure, para, value).ToString();
            Console.WriteLine(str);
            return str;
        }
    }
}
