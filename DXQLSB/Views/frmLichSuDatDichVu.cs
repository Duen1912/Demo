using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXQLSB.Views
{
    public partial class frmLichSuDatDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        public frmLichSuDatDichVu()
        {
            InitializeComponent();
        }

        private void gridControlLichSuDatDichVu_Load(object sender, EventArgs e)
        {
            this.thongtindatdichvuTableAdapter.Fill(this.thongTinDatdichVuDataSet.thongtindatdichvu);
        }
    }
}
