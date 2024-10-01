using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Model
{
    class TraSanMod
    {
        // Khai báo biến
        protected string tensan { get; set; }
        protected int masan { get; set; }
        protected int tongtiensan { get; set; }
        protected int tongtiendichvu { get; set; }
        protected int tongcong { get; set; }
        protected string ngaytao { get; set; }
        protected string nguoitao { get; set; }
        // Hàm dựng
        public TraSanMod(int _masan)
        {
            this.masan = _masan;
        }
        // Hàm dựng
        public TraSanMod(string _tensan, int _masan, int _tongtiensan, int _tongtiendichvu, 
            int _tongcong, string _ngaytao, string _nguoitao)
        {
            this.tensan = _tensan;
            this.masan = _masan;
            this.tongtiensan = _tongtiensan;
            this.tongtiendichvu = _tongtiendichvu;
            this.tongcong = _tongcong;
            this.ngaytao = _ngaytao;
            this.nguoitao = _nguoitao;
        }
        // Cập nhật trạng thái sân lại thành đang trống
        public string LamTrongSan()
        {
            string str = "";
            string[] para = new string[1] { "@masan" };
            object[] value = new object[1] { masan };
            str = Model.Connection.Excute_Sql("spLamTrong_San", System.Data.CommandType.StoredProcedure, para, value).ToString();
            Console.WriteLine(str);
            return str;
        }
        // Cập nhật trạng thái isdathanhtoan trong bảng thongtindatdichvu lại thành 1 = True
        public string ThanhToanDichVu()
        {
            string str = "";
            string[] para = new string[1] { "@masan" };
            object[] value = new object[1] { masan };
            str = Model.Connection.Excute_Sql("spThanhToan_DichVu", System.Data.CommandType.StoredProcedure, para, value).ToString();
            Console.WriteLine(str);
            return str;
        }
        // Cập nhật trạng thái isdathanhtoan trong bảng thongtindatsan lại thành 1 = True
        public string ThanhToanSan()
        {
            string str = "";
            string[] para = new string[1] { "@masan" };
            object[] value = new object[1] { masan };
            str = Model.Connection.Excute_Sql("spThanhToan_San", System.Data.CommandType.StoredProcedure, para, value).ToString();
            Console.WriteLine(str);
            return str;
        }
        // Insert vào bảng hoadon
        public string TaoHoaDon()
        {
            string str = "";
            string[] para = new string[7] { "@tensan", "@masan", "@tongtiensan", "@tongtiendichvu",
                "@tongcong","@ngaytao", "@nguoitao" };
            object[] value = new object[7] { tensan, masan, tongtiensan, tongtiendichvu, tongcong,
                ngaytao, nguoitao };
            str = Model.Connection.Excute_Sql("spInsert_HoaDon", System.Data.CommandType.StoredProcedure, para, value).ToString();
            Console.WriteLine(str);
            return str;
        }
    }
}
