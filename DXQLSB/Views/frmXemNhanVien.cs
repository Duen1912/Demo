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
    public partial class frmXemNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        public frmXemNhanVien()
        {
            InitializeComponent();
        }

        private void gridControlNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thongtinkhachhangDS.thongtinkhachhang' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.nhanVienDataSet.nhanvien);
        }

        private void gridControlNhanVien_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                try
                {
                    this.Validate();
                    this.nhanvienBindingSource.EndEdit();
                    this.nhanvienTableAdapter.Update(this.nhanVienDataSet);
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
