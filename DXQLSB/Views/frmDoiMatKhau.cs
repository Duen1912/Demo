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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMatKhauHienTai.Properties.PasswordChar = '*';
            txtMatKhauMoi.Properties.PasswordChar = '*';
            txtNhapLaiMatKhau.Properties.PasswordChar = '*';
            
        }
    }
}