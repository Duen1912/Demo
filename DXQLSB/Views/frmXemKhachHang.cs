using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Data.Browsing;

namespace DXQLSB.Views
{
    public partial class frmXemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        
        public frmXemKhachHang()
        {
            InitializeComponent();
        }

        private void frmXemKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thongtinkhachhangDS.thongtinkhachhang' table. You can move, or remove it, as needed.
            this.thongtinkhachhangTableAdapter.Fill(this.thongtinkhachhangDS.thongtinkhachhang);

        }

        private void gridTTKH_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if(e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                try
                {
                    this.Validate();
                    this.thongtinkhachhangBindingSource.EndEdit();
                    this.thongtinkhachhangTableAdapter.Update(this.thongtinkhachhangDS);
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