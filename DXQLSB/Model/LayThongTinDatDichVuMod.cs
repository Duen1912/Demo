using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXQLSB.Model
{
    class LayThongTinDatDichVuMod
    {
        // Khai báo biến
        protected int masan { get; set; }
        // Hàm dựng
        public LayThongTinDatDichVuMod(int _masan)
        {
            this.masan = _masan;
        }

        public DataTable LayThongTinDatDichVu()
        {
            DataTable dt;
            string sql = string.Format("SELECT *  FROM thongtindatdichvu WHERE masan = {0} AND isdathanhtoan =0", masan);
            dt = Model.Connection.FillDataTable(sql);
            Console.WriteLine(sql);
            return dt;
        }
    }
}
