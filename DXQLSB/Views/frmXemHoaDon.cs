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
    public partial class frmXemHoaDon : DevExpress.XtraEditors.XtraUserControl
    {
        public frmXemHoaDon()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            this.hoadonTableAdapter.Fill(hoaDonDataSet.hoadon);
        }
    }
}
