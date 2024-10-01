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
    public partial class frmBangLoaiDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        public frmBangLoaiDichVu()
        {
            InitializeComponent();
        }

        private void gridControlBangLoaiDichVu_Load(object sender, EventArgs e)
        {
            this.loaidichvuTableAdapter.Fill(loaiDichVuDataSet.loaidichvu);
        }

        private void gridControlBangLoaiDichVu_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                try
                {
                    this.Validate();
                    this.loaidichvuBindingSource.EndEdit();
                    this.loaidichvuTableAdapter.Update(this.loaiDichVuDataSet);
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
