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
    public partial class frmChonDichVu : DevExpress.XtraEditors.XtraForm
    {
        public frmChonDichVu()
        {
            InitializeComponent();
        }

        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        { 
               // Console.WriteLine(cbbDonGia.Text);
                int donGia = Int32.Parse(cbbDonGia.Text, System.Globalization.NumberStyles.AllowThousands);
                int soLuong = Int32.Parse(txtSoLuong.Value.ToString());
                int thanhTien = donGia * soLuong;
                txtThanhTien.Text = String.Format("{0:#,###0}", thanhTien);
        }

        private void cbbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbDonGia.SelectedIndex = cbbSanPham.SelectedIndex;
        }

        private void cbbSanDaDat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbMaSan.SelectedIndex = cbbSanDaDat.SelectedIndex;
            cbbLoaiSan.SelectedIndex = cbbSanDaDat.SelectedIndex;
        }

        private void txtSoLuong_MouseClick(object sender, MouseEventArgs e)
        {
            cbbSanDaDat_SelectedIndexChanged(sender, e);
        }
    }
}