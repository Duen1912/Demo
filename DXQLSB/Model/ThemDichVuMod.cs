using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Model
{
    class ThemDichVuMod
    {
        // Khai báo biến
        protected int madichvu { get; set; }
        protected string tensanpham { get; set; }
        protected int dongia { get; set; }
        // Hàm dựng
        public ThemDichVuMod(int _madichvu, string _tensanpham, int _dongia)
        {
            this.madichvu = _madichvu;
            this.tensanpham = _tensanpham;
            this.dongia = _dongia;
        }

        public string ThemDichVu()
        {
            string isthemdichvu = "";
            string[] para = new string[3] { "@madichvu", "@tensanpham","@dongia" };
            object[] value = new object[3] { madichvu, tensanpham, dongia };
            isthemdichvu = Model.Connection.Excute_Sql("spInsert_DichVu", System.Data.CommandType.StoredProcedure, para, value).ToString();
            Console.WriteLine(isthemdichvu);
            return isthemdichvu;
        }
    }
}
