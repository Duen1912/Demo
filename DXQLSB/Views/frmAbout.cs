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
    public partial class frmAbout : DevExpress.XtraEditors.XtraForm
    {
        public static int isSuaClicked =  0;
        public static string tendangnhap;
        public frmAbout()
        {
            InitializeComponent();
            
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = true;
            cbbGioiTinh.Enabled = true;
            txtDiaChi.Enabled = true;
            isSuaClicked = 1;

        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = tendangnhap;
            DataTable dt = null;
            dt = Controller.AboutCtrl.LayThongTinTaiKhoan(tendangnhap);
            if(dt == null)
            {
                MessageBox.Show("Lấy thông tin tài khoản thất bại");

            }
            else
            {
               foreach (DataRow row in dt.Rows)
                {
                    //MessageBox.Show("Lấy thông tin tài khoản thành công");
                    string msnv = row["msnv"].ToString();
                    string hoten = row["hoten"].ToString();
                    string gioitinh = row["gioitinh"].ToString();
                    string diachi = row["diachi"].ToString();
                    string ngaytao = row["ngaytao"].ToString();
                    if (gioitinh == "True")
                    {
                        cbbGioiTinh.SelectedIndex = 0;
                    }
                    else
                    {
                        cbbGioiTinh.SelectedIndex = 1;
                    }
                    
                    txtMSNV.Text = msnv;
                    txtHoTen.Text = hoten;
                    
                    txtDiaChi.Text = diachi;
                    txtNgayTao.Text = ngaytao;

                }
               
              
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(isSuaClicked == 1)
            {
                string newHoTen = txtHoTen.Text;
                int newGioiTinh = 1;
                if (cbbGioiTinh.Text == "Nữ" && newGioiTinh == 1)
                {
                    newGioiTinh = 0;
                }
                string newDiaChi = txtDiaChi.Text;
                int masonhanvien = int.Parse(txtMSNV.Text);
                string result = "";
                result = Controller.UpdateInfoCtrl.CapNhatThongTinTaiKhoan(newHoTen, newGioiTinh, newDiaChi, masonhanvien);
                if(result == "")
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Cập nhật thông tin thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}