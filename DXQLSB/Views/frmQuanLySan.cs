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
using DevExpress.XtraGrid.Views.Grid;

namespace DXQLSB.Views
{
    public partial class frmQuanLySan : DevExpress.XtraEditors.XtraUserControl
    {
        public frmQuanLySan()
        {
            InitializeComponent();
        }

        private void gridControlSan_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                try
                {
                    this.Validate();
                    this.sanBindingSource.EndEdit();
                    this.sanTableAdapter.Update(this.sanDataSet);
                    XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    XtraMessageBox.Show("Lưu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void gridControlSan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thongtinkhachhangDS.thongtinkhachhang' table. You can move, or remove it, as needed.
            this.sanTableAdapter.Fill(this.sanDataSet.san);
        }

        private void gridViewSan_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["isdangdat"], false);
        }

        private void gridViewSan_ShownEditor(object sender, EventArgs e)
        {

        }

        private void gridViewSan_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["isdangdat"], false);
        }
    }
}
