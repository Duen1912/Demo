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
    public partial class frmXemLichSuDatSan : DevExpress.XtraEditors.XtraUserControl
    {
        public frmXemLichSuDatSan()
        {
            InitializeComponent();
        }

        private void gridControlLichSuSan_Load(object sender, EventArgs e)
        {
            this.thongtindatsanTableAdapter.Fill(this.thongTinDatSanDataSet.thongtindatsan);
        }
    }
}
