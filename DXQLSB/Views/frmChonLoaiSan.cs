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
    public partial class frmChonLoaiSan : DevExpress.XtraEditors.XtraForm
    {
        
        public frmChonLoaiSan()
        {
            InitializeComponent();
        }

        private void frmChonLoaiSan_Load(object sender, EventArgs e)
        {

            DataTable dtLoaiSan = null;
            DataTable dtDonGia = null;
            dtLoaiSan = Controller.LayThongTinSanCtrl.LayThongTinLoaiSan();
            dtDonGia = Controller.LayThongTinSanCtrl.LayThongTinDonGia();
            // Add vào combobox
            foreach(DataRow row in dtLoaiSan.Rows)
            {
                cbbLoaiSan.Properties.Items.Add(row["loaisan"].ToString());
            }
            
            foreach (DataRow row in dtDonGia.Rows)
            {
                cbbDonGia.Properties.Items.Add(row["dongia"].ToString());
            }
        }
    }
}