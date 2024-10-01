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

namespace DXQLSB.Views
{
    public partial class frmThemDichVu : DevExpress.XtraEditors.XtraForm
    {
        public frmThemDichVu()
        {
            InitializeComponent();
        }

        private void txtDonGiaSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbbTenLoaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbMaDichVu.SelectedIndex = cbbTenLoaiDichVu.SelectedIndex;
        }

        private void frmThemDichVu_Load(object sender, EventArgs e)
        {
            
        }



        private void txtDonGiaSanPham_EditValueChanged(object sender, EventArgs e)
        {
            int donGia = Int32.Parse(txtDonGiaSanPham.Text, System.Globalization.NumberStyles.AllowThousands);
            txtDonGiaSanPham.Text = String.Format("{0:#,###0}", donGia);
        }

        private void txtDonGiaSanPham_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }
    }
}