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
    public partial class frmBangDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        public frmBangDichVu()
        {
            InitializeComponent();
        }

        private void gridControlXemDichVu_Load(object sender, EventArgs e)
        {
            this.dichvuTableAdapter.Fill(dichVuDataSet.dichvu);
        }

        private void gridControlXemDichVu_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                try
                {
                    this.Validate();
                    this.dichvuBindingSource.EndEdit();
                    this.dichvuTableAdapter.Update(this.dichVuDataSet);
                    XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    XtraMessageBox.Show("Lưu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
