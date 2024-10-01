//-----------------------------------------------------------------------
// <copyright file="FormMain.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DXQLSB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using DevExpress.XtraEditors;
    using DXQLSB.Views;

    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string tendangnhap;
        public static bool idLogin = false;
        public formMain()
        {
            InitializeComponent();
            AnMenuSauLogin(true, idLogin);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.barThoiGian.Caption = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        public void SkinDefault()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2019 Colorful";
        }

        //idLogin để phát triển phân quyền
        // Ẩn menu khi chưa đăng nhập
        public void AnMenuSauLogin(bool e, bool _idLogin)
        {

            btnDangNhap.Enabled = e;
            btnDoiMatKhau.Enabled = !e;
            btnAbout.Enabled = !e;
            btnDangXuat.Enabled = !e;
            btnDatSan.Enabled = !e;
            btnDatDichVu.Enabled = !e;
            btnTraSan.Enabled = !e;
            ribbonGroupKhachHang.Enabled = !e;
            usrctrlHienThi.Visible = !e;
            ribbonPageQuanLy.Visible = _idLogin;
           // ribbonPageBaoCao.Visible = _idLogin;


        }

        private void formMain_Load(object sender, EventArgs e)
        {
            SkinDefault();
            timer1.Start();
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Media.SystemSounds.Question.Play();
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin login = null;
        Check_Login:
            if (login == null || login.IsDisposed)
            {
                login = new frmLogin();
            }
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (login.txtTenDangNhap.Text == "")
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    XtraMessageBox.Show("Tên đăng nhập không được bỏ trống !");
                    goto Check_Login;
                }
                if (login.txtMatKhau.Text == "")
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    XtraMessageBox.Show("Nhập mật khẩu !");
                    goto Check_Login;
                }
                string check = "";
                tendangnhap = login.txtTenDangNhap.Text;
                //Mật khẩu gọi hàm SHA256 để mã hoá
                string matkhau = Model.UserControl.SHA256(login.txtMatKhau.Text);
                check = Controller.LoginCtrl.KiemTraDangNhap(tendangnhap, matkhau);
                if (check == "")
                {
                    System.Media.SystemSounds.Hand.Play();
                    XtraMessageBox.Show("Tài khoản, mật khẩu không đúng hoặc đã bị khoá");
                    login.txtMatKhau.Text = "";
                    goto Check_Login;
                }
                else
                {
                    string isadmin = "";
                    isadmin = Controller.LoginCtrl.KiemTraAdmin(tendangnhap);
                    if (isadmin == "True")
                    {
                        System.Media.SystemSounds.Exclamation.Play();
                        XtraMessageBox.Show("Bạn đã đăng nhập thành công tài khoản quản trị ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idLogin = true;
                        txtHeaderTenTaiKhoan.Caption = tendangnhap;
                        AnMenuSauLogin(false, idLogin);
                    }
                    else
                    {
                        idLogin = false;
                        txtHeaderTenTaiKhoan.Caption = tendangnhap;
                        AnMenuSauLogin(false, idLogin);
                    }
                }
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Media.SystemSounds.Hand.Play();
            if (XtraMessageBox.Show("Bạn có thực sự muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                txtHeaderTenTaiKhoan.Caption = ".";
                
                AnMenuSauLogin(true, false);
                btnDangNhap_ItemClick(sender, e);
                usrctrlHienThi.Controls.Clear();
            }
        }



        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau frmDMK = null;
            if (frmDMK == null || frmDMK.IsDisposed)
            {
                frmDMK = new frmDoiMatKhau();
            }
            Check_Doi_Mat_Khau:
            if (frmDMK.ShowDialog() == DialogResult.OK)
            {
                if (frmDMK.txtMatKhauHienTai.Text == "")
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    XtraMessageBox.Show("Vui lòng nhập mật khẩu hiện tại !");
                    goto Check_Doi_Mat_Khau;
                }
                if (frmDMK.txtMatKhauMoi.Text == "")
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    XtraMessageBox.Show("Vui lòng nhập mật khẩu mới !");
                    goto Check_Doi_Mat_Khau;
                }
                if (frmDMK.txtNhapLaiMatKhau.Text != frmDMK.txtMatKhauMoi.Text)
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    XtraMessageBox.Show("Nhập lại mật khẩu không khớp nhau !");
                    goto Check_Doi_Mat_Khau;
                }
                string check = "";
                tendangnhap = txtHeaderTenTaiKhoan.Caption;
                // Kiểm tra mật khẩu hiện tại
                string matkhauhientai = Model.UserControl.SHA256(frmDMK.txtMatKhauHienTai.Text);
                string matkhaumoi = Model.UserControl.SHA256(frmDMK.txtMatKhauMoi.Text);
                check = Controller.LoginCtrl.KiemTraDangNhap(tendangnhap, matkhauhientai);
                if (check == "")
                {
                    System.Media.SystemSounds.Hand.Play();
                    XtraMessageBox.Show("Mật khẩu hiện tại không chính xác");
                    goto Check_Doi_Mat_Khau;
                }
                else
                {
                    string doimatkhau = "";
                    // Lấy tên tài khoản đã được hiện thị ở status bar bằng mật khẩu đã được mã hoá
                    doimatkhau = Controller.DoiMatKhauCtrl.DoiMatKhau(txtHeaderTenTaiKhoan.Caption, matkhaumoi);
                    if (doimatkhau == "0")
                    {
                        System.Media.SystemSounds.Exclamation.Play();
                        XtraMessageBox.Show("Đổi mật khẩu thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        XtraMessageBox.Show("Đổi mật khẩu thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void btnAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            frmAbout frmAbt = null;
            if (frmAbt == null || frmAbt.IsDisposed)
            {
                frmAbt = new frmAbout();
                frmAbout.tendangnhap = tendangnhap;
            }
            if (frmAbt.ShowDialog() == DialogResult.OK)
            {
                
                
                
            }
        }

        private void btnDatSan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChonLoaiSan frmCLS = null;
            
            if (frmCLS == null || frmCLS.IsDisposed)
            {
                frmCLS = new frmChonLoaiSan();
                
            }
            if (frmCLS.ShowDialog() == DialogResult.OK)
            {
                int loaisan = -1;
                int dongia = -1;
                string trangthai = frmCLS.cbbTrangThaiSan.Text;
                if(frmCLS.cbbLoaiSan.Text != "All")
                {
                    loaisan = Int32.Parse(frmCLS.cbbLoaiSan.Text);
                }
                if (frmCLS.cbbDonGia.Text != "All")
                {
                    dongia = Int32.Parse(frmCLS.cbbDonGia.Text);
                }
                DataTable tableSan;
                if(trangthai != "All")
                {
                    tableSan = Controller.LayThongTinSanCtrl.LayThongTinSan(loaisan, dongia, 0);
                }
                else
                {
                    tableSan = Controller.LayThongTinSanCtrl.LayThongTinSan(loaisan, dongia, 1);
                }
               
                // Gửi data table qua form Đặt sân để đổ ra usercontrol
                frmDatSan.tableSan = tableSan;
                // haiz mệt quá
                frmDatSan frmdatSan = new frmDatSan();
                // Chỉnh dock cho usrctrlHienthi
                frmdatSan.Dock = DockStyle.Fill;
                //Add frm đặt sân r lôi nó lên màn hình chính
                usrctrlHienThi.Controls.Add(frmdatSan);

                frmdatSan.BringToFront();
            }
            
        }

        private void btnDatDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable _loaiDichVuTable;
            _loaiDichVuTable = Controller.LayLoaiDichVuCtrl.LayThongTinLoaiDichVu();
            // Lại bước quen thuộc, gửi datatable qua bên kia
            frmDatDichVu.loaiDichVuTable = _loaiDichVuTable;
            //Khai báo form
            frmDatDichVu frmDDV = new frmDatDichVu();
            // Chỉnh dock
            frmDDV.Dock = DockStyle.Fill;
            //Add into uercontrol
            usrctrlHienThi.Controls.Add(frmDDV);
            // Lôi lên trước
            frmDDV.BringToFront();
        }

        private void btnTraSan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable _sanDangDatTable;
            _sanDangDatTable = Controller.LayThongTinSanCtrl.LayThongTinSanDaDat();
            //
            frmTraSan.sanDangDatTable = _sanDangDatTable;
            //
            frmTraSan frmTS = new frmTraSan();
            //
            frmTraSan.userWorking = txtHeaderTenTaiKhoan.Caption;
            frmTS.Dock = DockStyle.Fill;
            //
            usrctrlHienThi.Controls.Add(frmTS);
            //
            frmTS.BringToFront();
        }

        private void btnXemKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXemKhachHang frmXKH = null;

            if (frmXKH == null || frmXKH.IsDisposed)
            {
                frmXKH = new frmXemKhachHang();
                frmXKH.ShowDialog();
            }
            
        }

        private void btnXemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXemNhanVien frmXNV = new frmXemNhanVien();
            //
            frmXNV.Dock = DockStyle.Fill;
            //
            usrctrlHienThi.Controls.Add(frmXNV);
            //
            frmXNV.BringToFront();
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTaoTaiKhoan frmTTK = null;
            int hople = 0;
            int _msnv = 0;
            if (frmTTK == null || frmTTK.IsDisposed)
            {
                frmTTK = new frmTaoTaiKhoan();
                
            }
            Check_NhanVien:
            if (frmTTK.ShowDialog() == DialogResult.Retry)
            {
                if (frmTTK.txtMSNV.Text == "")
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    XtraMessageBox.Show("Vui lòng nhập mã số nhân viên !");
                    goto Check_NhanVien;
                }
                else
                {
                    _msnv = Int32.Parse(frmTTK.txtMSNV.Text);
                    string kiemTra = Controller.TaoTaiKhoanCtrl.KiemTra(_msnv);
                    if (kiemTra != "")
                    {
                        string tontaitaikhoan = Controller.TaoTaiKhoanCtrl.KiemTraTonTaiTaiKhoan(_msnv);
                        if(tontaitaikhoan != "")
                        {
                            frmTTK.lblKiemTra.Text = "Mã số nhân viên đã được cấp tài khoản.";
                            frmTTK.lblKiemTra.ForeColor = Color.Red;
                            frmTTK.lblKiemTra.Visible = true;
                            goto Check_NhanVien;
                        }
                        else
                        {
                            frmTTK.lblKiemTra.Text = "Mã số nhân viên hợp lệ.";
                            frmTTK.lblKiemTra.ForeColor = Color.Green;
                            frmTTK.lblKiemTra.Visible = true;
                            if (MessageBox.Show("Bạn có muốn đăng kí cho nhân viên có mã số là " + _msnv + " ?", "Xác nhận",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) ==
                        DialogResult.Yes)
                            {
                                hople = 1;
                                frmTTK.txtTenDangNhap.Enabled = true;
                                frmTTK.txtMSNV.Enabled = false;
                                frmTTK.btnTao.Enabled = true;
                                frmTTK.btnKiemTra.Enabled = false;
                                goto Check_NhanVien;

                            }
                            else
                            {
                                goto Check_NhanVien;
                            }
                            
                        }
                        
                    }
                    else
                    {
                        hople = 0;
                        frmTTK.lblKiemTra.Text = "Mã số nhân viên không hợp lệ hoặc chưa được cấp.";
                        frmTTK.lblKiemTra.ForeColor = Color.Red;
                        frmTTK.lblKiemTra.Visible = true;
                        goto Check_NhanVien;
                    }
                }
            }
            else 
            {
                if(frmTTK.DialogResult == DialogResult.OK)
                {
                    if (frmTTK.txtTenDangNhap.Text == "")
                    {
                        System.Media.SystemSounds.Asterisk.Play();
                        XtraMessageBox.Show("Vui lòng nhập tên đang nhập !");
                        goto Check_NhanVien;
                    }
                    else
                    {
                        if(hople != 0)
                        {
                            string tendangnhap = frmTTK.txtTenDangNhap.Text;
                            string kiemtratendangnhap = Controller.TaoTaiKhoanCtrl.KiemTraTrungTenDangNhap(tendangnhap);
                            if (kiemtratendangnhap != "")
                            {
                                frmTTK.lblKTTenDangNhap.Text = "Tên đăng nhập đã tồn tại.";
                                frmTTK.lblKTTenDangNhap.Visible = true;
                                goto Check_NhanVien;
                            }
                            else
                            {
                                if (MessageBox.Show("Bạn có muốn đăng kí cho nhân viên có mã số là " + 
                                    _msnv + " tên đăng nhập là "+tendangnhap+" ?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                                {
                                    string matkhaumacdinh = "vinmatch";
                                    string _tendangnhap = frmTTK.txtTenDangNhap.Text;
                                    // Mã hoá mật khẩu khỏi dòm nè con
                                    string _matkhau = Model.UserControl.SHA256(matkhaumacdinh);
                                    //
                                    string themtaikhoan = Controller.TaoTaiKhoanCtrl.ThemTaiKhoan(_msnv, _matkhau, _tendangnhap);
                                    Console.WriteLine(_matkhau);
                                    if (themtaikhoan != "")
                                    {
                                        XtraMessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("Thêm tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void btnKhoaTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoaTaiKhoan frmKHTK = null;
            int hople = 0;
            int _msnv = 0;
            if (frmKHTK == null || frmKHTK.IsDisposed)
            {
                frmKHTK = new frmKhoaTaiKhoan();

            }
        Check_NhanVien:
            if (frmKHTK.ShowDialog() == DialogResult.Retry)
            {

                if (frmKHTK.txtMSNV.Text == "")
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    XtraMessageBox.Show("Vui lòng nhập mã số nhân viên !");
                    goto Check_NhanVien;
                }
                else
                {
                    _msnv = Int32.Parse(frmKHTK.txtMSNV.Text);
                    string kiemTra = Controller.TaoTaiKhoanCtrl.KiemTra(_msnv);
                    // kiểm tra xem có tồn tại nhân viên ko
                    if (kiemTra != "")
                    {
                        // Kiểm tra có tồn tại tài khoản mà có mã số nhân viên đó ko
                        string tontaitaikhoan = Controller.TaoTaiKhoanCtrl.KiemTraTonTaiTaiKhoan(_msnv);
                        if (tontaitaikhoan != "")
                        {
                            hople = 1;
                            frmKHTK.lblKiemTra.Text = "Tài khoản hợp lệ. ";
                            frmKHTK.lblKiemTra.ForeColor = Color.Green;
                            frmKHTK.lblKiemTra.Visible = true;
                            DataTable dt = Controller.KichHoatTaiKhoanCtrl.LayThongTinTaiKhoanNhanVien(_msnv);

                            foreach (DataRow row in dt.Rows)
                            {
                                frmKHTK.txtTenDangNhap.Text = row["tendangnhap"].ToString();
                                frmKHTK.txtTenNhanVien.Text = row["hoten"].ToString();
                                if (row["trangthai"].ToString() == "True")
                                {
                                    frmKHTK.lblHoatDong.Text = "Tài khoản này đã được kích hoạt.";
                                    frmKHTK.lblHoatDong.ForeColor = Color.Green;
                                    frmKHTK.lblHoatDong.Visible = true;
                                    frmKHTK.btnKichHoat.Enabled = true;

                                }
                                else
                                {
                                    frmKHTK.lblHoatDong.Text = "Tài khoản này đang bị khoá.";
                                    frmKHTK.lblHoatDong.ForeColor = Color.Red;
                                    frmKHTK.lblHoatDong.Visible = true;
                                    frmKHTK.btnKichHoat.Enabled = false;

                                }
                            }
                            goto Check_NhanVien;
                        }
                        else
                        {
                            hople = 0;
                            frmKHTK.lblKiemTra.Text = "Mã số nhân viên này chưa tạo tài khoản";
                            frmKHTK.lblKiemTra.ForeColor = Color.Red;
                            frmKHTK.lblKiemTra.Visible = true;

                            frmKHTK.txtTenDangNhap.Text = "";
                            frmKHTK.txtTenNhanVien.Text = "";
                            goto Check_NhanVien;

                        }

                    }
                    else
                    {
                        hople = 0;
                        frmKHTK.lblKiemTra.Text = "Mã số nhân viên không hợp lệ hoặc chưa được cấp.";
                        frmKHTK.lblKiemTra.ForeColor = Color.Red;
                        frmKHTK.lblKiemTra.Visible = true;
                        frmKHTK.txtTenDangNhap.Text = "";
                        frmKHTK.txtTenNhanVien.Text = "";
                        goto Check_NhanVien;
                    }
                }
            }
            else
            {
                if (frmKHTK.DialogResult == DialogResult.OK && hople == 1)
                {
                    if (MessageBox.Show("Bạn có muốn khoá tài khoản này", "Xác nhận",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string Khoa = Controller.KichHoatTaiKhoanCtrl.KhoaTaiKhoan(_msnv);
                        if (Khoa != "")
                        {
                            XtraMessageBox.Show("Khoá tài khoản " + frmKHTK.txtTenDangNhap.Text + " của " +
                                frmKHTK.txtTenNhanVien.Text + " thành công", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Khoá tài khoản " + frmKHTK.txtTenDangNhap + " của " +
                                frmKHTK.txtTenNhanVien + " thất bại", "Lỗi", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnKichHoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKichHoatTaiKhoan frmKHTK = null;
            int hople = 0;
            int _msnv = 0;
            if (frmKHTK == null || frmKHTK.IsDisposed)
            {
                frmKHTK = new frmKichHoatTaiKhoan();

            }
        Check_NhanVien:
            if (frmKHTK.ShowDialog() == DialogResult.Retry)
            {

                if (frmKHTK.txtMSNV.Text == "")
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    XtraMessageBox.Show("Vui lòng nhập mã số nhân viên !");
                    goto Check_NhanVien;
                }
                else
                {
                    _msnv = Int32.Parse(frmKHTK.txtMSNV.Text);
                    string kiemTra = Controller.TaoTaiKhoanCtrl.KiemTra(_msnv);
                    // kiểm tra xem có tồn tại nhân viên ko
                    if (kiemTra != "")
                    {
                        // Kiểm tra có tồn tại tài khoản mà có mã số nhân viên đó ko
                        string tontaitaikhoan = Controller.TaoTaiKhoanCtrl.KiemTraTonTaiTaiKhoan(_msnv);
                        if (tontaitaikhoan != "")
                        {
                            hople = 1;
                            frmKHTK.lblKiemTra.Text = "Tài khoản hợp lệ. ";
                            frmKHTK.lblKiemTra.ForeColor = Color.Green;
                            frmKHTK.lblKiemTra.Visible = true;
                            DataTable dt = Controller.KichHoatTaiKhoanCtrl.LayThongTinTaiKhoanNhanVien(_msnv);
                            
                            foreach (DataRow row in dt.Rows)
                            {
                                frmKHTK.txtTenDangNhap.Text = row["tendangnhap"].ToString();
                                frmKHTK.txtTenNhanVien.Text = row["hoten"].ToString();
                                if(row["trangthai"].ToString() == "True")
                                {
                                    frmKHTK.lblHoatDong.Text = "Tài khoản này đã được kích hoạt.";
                                    frmKHTK.lblHoatDong.ForeColor = Color.Green;
                                    frmKHTK.lblHoatDong.Visible = true;
                                    frmKHTK.btnKichHoat.Enabled = false;
                                   
                                }
                                else
                                {
                                    frmKHTK.lblHoatDong.Text = "Tài khoản này đang bị khoá.";
                                    frmKHTK.lblHoatDong.ForeColor = Color.Red;
                                    frmKHTK.lblHoatDong.Visible = true;
                                    frmKHTK.btnKichHoat.Enabled = true;
                                   
                                }
                            }
                            goto Check_NhanVien;
                        }
                        else
                        {
                            hople = 0;
                            frmKHTK.lblKiemTra.Text = "Mã số nhân viên này chưa tạo tài khoản";
                            frmKHTK.lblKiemTra.ForeColor = Color.Red;
                            frmKHTK.lblKiemTra.Visible = true;

                            frmKHTK.txtTenDangNhap.Text = "";
                            frmKHTK.txtTenNhanVien.Text = "";
                            goto Check_NhanVien;

                        }

                    }
                    else
                    {
                        hople = 0;
                        frmKHTK.lblKiemTra.Text = "Mã số nhân viên không hợp lệ hoặc chưa được cấp.";
                        frmKHTK.lblKiemTra.ForeColor = Color.Red;
                        frmKHTK.lblKiemTra.Visible = true;
                        frmKHTK.txtTenDangNhap.Text = "";
                        frmKHTK.txtTenNhanVien.Text = "";
                        goto Check_NhanVien;
                    }
                }
            }
            else
            {
                if (frmKHTK.DialogResult == DialogResult.OK && hople == 1)
                {
                    if (MessageBox.Show("Bạn có muốn kích hoạt tài khoản này", "Xác nhận",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string kichhoattaikhoan = Controller.KichHoatTaiKhoanCtrl.KichHoatTaiKhoan(_msnv);
                        if(kichhoattaikhoan != "")
                        {
                            XtraMessageBox.Show("Kích hoạt tài khoản " + frmKHTK.txtTenDangNhap.Text + " của " +
                                frmKHTK.txtTenNhanVien.Text + " thành công", "Thông báo", MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Kích hoạt tài khoản " + frmKHTK.txtTenDangNhap + " của " +
                                frmKHTK.txtTenNhanVien + " thất bại", "Lỗi", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnXemSan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLySan frmQLS = new frmQuanLySan();
            //
            frmQLS.Dock = DockStyle.Fill;
            //
            usrctrlHienThi.Controls.Add(frmQLS);
            //
            frmQLS.BringToFront();
        }

        private void btnXemLichSuDatSan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXemLichSuDatSan frmLSDS = new frmXemLichSuDatSan();
            frmLSDS.Dock = DockStyle.Fill;
            usrctrlHienThi.Controls.Add(frmLSDS);
            frmLSDS.BringToFront();
        }

        private void btnLichSuDatDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLichSuDatDichVu frmLSDDV = new frmLichSuDatDichVu();
            frmLSDDV.Dock = DockStyle.Fill;
            usrctrlHienThi.Controls.Add(frmLSDDV);
            frmLSDDV.BringToFront();
        }

        private void btnHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXemHoaDon frmXHD = new frmXemHoaDon();
            frmXHD.Dock = DockStyle.Fill;
            usrctrlHienThi.Controls.Add(frmXHD);
            frmXHD.BringToFront();
        }

        private void btnXemDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBangDichVu frmBDV = new frmBangDichVu();
            frmBDV.Dock = DockStyle.Fill;
            usrctrlHienThi.Controls.Add(frmBDV);
            frmBDV.BringToFront();
        }

        private void btnBangLoaiDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBangLoaiDichVu frmBLDV = new frmBangLoaiDichVu();
            frmBLDV.Dock = DockStyle.Fill;
            usrctrlHienThi.Controls.Add(frmBLDV);
            frmBLDV.BringToFront();
        }

        private void btnThemDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemDichVu frmTDV = null;
            if (frmTDV == null || frmTDV.IsDisposed)
            {
                frmTDV = new frmThemDichVu();
                DataTable loaiDichVuTable = null;
                loaiDichVuTable = Controller.LayLoaiDichVuCtrl.LayThongTinLoaiDichVu();
                if(loaiDichVuTable.Rows.Count != 0)
                {
                    foreach(DataRow row in loaiDichVuTable.Rows)
                    {
                        frmTDV.cbbTenLoaiDichVu.Properties.Items.Add(row["tenloai"]);
                        frmTDV.cbbMaDichVu.Properties.Items.Add(row["madichvu"]);
                    }
                    frmTDV.cbbTenLoaiDichVu.SelectedIndex = 0;
                    frmTDV.cbbMaDichVu.SelectedIndex = 0;
                }
                else
                {
                    frmTDV.cbbTenLoaiDichVu.Properties.Items.Add("Chưa có loại dịch vụ nào");
                    frmTDV.cbbTenLoaiDichVu.SelectedIndex = 0;
                    frmTDV.cbbTenLoaiDichVu.Enabled = false;
                    frmTDV.btnThemNgay.Enabled = false;

                }
            }
        Check_ThemDichVu:
            if (frmTDV.ShowDialog() == DialogResult.OK)
            {
                if (frmTDV.txtTenSanPham.Text == "")
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    XtraMessageBox.Show("Vui lòng nhập tên sản phẩm !");
                    goto Check_ThemDichVu;
                }
                else if (frmTDV.txtDonGiaSanPham.Text == "")
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    XtraMessageBox.Show("Vui lòng nhập giá sản phẩm !");
                    goto Check_ThemDichVu;
                }
                else
                {
                    string isthemdichvu = "";
                    int _madichvu = Int32.Parse(frmTDV.cbbMaDichVu.Text);
                    string _tensanpham = frmTDV.txtTenSanPham.Text;
                    int _dongia = Int32.Parse(frmTDV.txtDonGiaSanPham.Text, System.Globalization.NumberStyles.AllowThousands);
                    isthemdichvu = Controller.ThemDichVuCtrl.ThemDichVu(_madichvu, _tensanpham, _dongia);
                    if (MessageBox.Show("Bạn có muốn thêm " + _tensanpham + " vào mục " + frmTDV.cbbTenLoaiDichVu.Text + 
                            " với đơn giá là "+ frmTDV.txtDonGiaSanPham.Text+" không!", "Xác nhận",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (isthemdichvu != "")
                        {
                            XtraMessageBox.Show("Thêm sản phẩm " + _tensanpham + " vào mục " + frmTDV.cbbTenLoaiDichVu.Text +
                            " thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Thêm sản phẩm " + _tensanpham + " vào mục " + frmTDV.cbbTenLoaiDichVu.Text +
                            " thất bại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }   
                }
            }
        }

        private void btnTongDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnTongQuan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTongQuan frmTQ = new frmTongQuan();
            frmTQ.ShowDialog();
        }
    }
}
