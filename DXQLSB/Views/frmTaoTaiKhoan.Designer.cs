namespace DXQLSB.Views
{
    partial class frmTaoTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupChonThongTinNguoiDat = new DevExpress.XtraEditors.GroupControl();
            this.txtMSNV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblKiemTra = new DevExpress.XtraEditors.LabelControl();
            this.btnKiemTra = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnTao = new DevExpress.XtraEditors.SimpleButton();
            this.lblKTTenDangNhap = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupChonThongTinNguoiDat)).BeginInit();
            this.groupChonThongTinNguoiDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(38, 50);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(137, 17);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Nhập mã số nhân viên";
            // 
            // groupChonThongTinNguoiDat
            // 
            this.groupChonThongTinNguoiDat.Controls.Add(this.lblKTTenDangNhap);
            this.groupChonThongTinNguoiDat.Controls.Add(this.txtMSNV);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl2);
            this.groupChonThongTinNguoiDat.Controls.Add(this.txtTenDangNhap);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl1);
            this.groupChonThongTinNguoiDat.Controls.Add(this.lblKiemTra);
            this.groupChonThongTinNguoiDat.Controls.Add(this.btnKiemTra);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl6);
            this.groupChonThongTinNguoiDat.Location = new System.Drawing.Point(40, 21);
            this.groupChonThongTinNguoiDat.Name = "groupChonThongTinNguoiDat";
            this.groupChonThongTinNguoiDat.Size = new System.Drawing.Size(541, 272);
            this.groupChonThongTinNguoiDat.TabIndex = 14;
            this.groupChonThongTinNguoiDat.Text = "Kiểm tra thông tin";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(202, 45);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Properties.MaxLength = 10;
            this.txtMSNV.Size = new System.Drawing.Size(284, 22);
            this.txtMSNV.TabIndex = 33;
            this.txtMSNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSNV_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(38, 239);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(386, 17);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "(Lưu ý: Mật khẩu đăng nhập được tạo mặc định là \"vinmatch\".";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Enabled = false;
            this.txtTenDangNhap.Location = new System.Drawing.Point(202, 166);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Properties.MaxLength = 50;
            this.txtTenDangNhap.Size = new System.Drawing.Size(284, 22);
            this.txtTenDangNhap.TabIndex = 29;
            this.txtTenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDangNhap_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(38, 169);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 17);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // lblKiemTra
            // 
            this.lblKiemTra.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic);
            this.lblKiemTra.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblKiemTra.Appearance.Options.UseFont = true;
            this.lblKiemTra.Appearance.Options.UseForeColor = true;
            this.lblKiemTra.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblKiemTra.Location = new System.Drawing.Point(38, 75);
            this.lblKiemTra.Name = "lblKiemTra";
            this.lblKiemTra.Size = new System.Drawing.Size(448, 17);
            this.lblKiemTra.TabIndex = 28;
            this.lblKiemTra.Text = "Mã số nhân viên không tồn tại hoặc đã có tài khoản.\r\n";
            this.lblKiemTra.Visible = false;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnKiemTra.Location = new System.Drawing.Point(202, 108);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(94, 29);
            this.btnKiemTra.TabIndex = 2;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(328, 328);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 29);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.Text = "Huỷ";
            // 
            // btnTao
            // 
            this.btnTao.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTao.Enabled = false;
            this.btnTao.Location = new System.Drawing.Point(191, 328);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(94, 29);
            this.btnTao.TabIndex = 30;
            this.btnTao.Text = "Tạo";
            // 
            // lblKTTenDangNhap
            // 
            this.lblKTTenDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic);
            this.lblKTTenDangNhap.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblKTTenDangNhap.Appearance.Options.UseFont = true;
            this.lblKTTenDangNhap.Appearance.Options.UseForeColor = true;
            this.lblKTTenDangNhap.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblKTTenDangNhap.Location = new System.Drawing.Point(38, 194);
            this.lblKTTenDangNhap.Name = "lblKTTenDangNhap";
            this.lblKTTenDangNhap.Size = new System.Drawing.Size(448, 17);
            this.lblKTTenDangNhap.TabIndex = 34;
            this.lblKTTenDangNhap.Text = "Tên đăng nhập đã tồn tại.";
            this.lblKTTenDangNhap.Visible = false;
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 390);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupChonThongTinNguoiDat);
            this.Controls.Add(this.btnTao);
            this.IconOptions.Image = global::DXQLSB.Properties.Resources.Add_User_Male_48px;
            this.Name = "frmTaoTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TẠO TÀI KHOẢN";
            ((System.ComponentModel.ISupportInitialize)(this.groupChonThongTinNguoiDat)).EndInit();
            this.groupChonThongTinNguoiDat.ResumeLayout(false);
            this.groupChonThongTinNguoiDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupChonThongTinNguoiDat;
        public DevExpress.XtraEditors.LabelControl lblKiemTra;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        public DevExpress.XtraEditors.SimpleButton btnKiemTra;
        public DevExpress.XtraEditors.TextEdit txtMSNV;
        public DevExpress.XtraEditors.SimpleButton btnTao;
        public DevExpress.XtraEditors.LabelControl lblKTTenDangNhap;
    }
}