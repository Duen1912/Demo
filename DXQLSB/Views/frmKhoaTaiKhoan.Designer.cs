﻿namespace DXQLSB.Views
{
    partial class frmKhoaTaiKhoan
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
            this.lblHoatDong = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMSNV = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblKiemTra = new DevExpress.XtraEditors.LabelControl();
            this.btnKiemTra = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnKichHoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupChonThongTinNguoiDat)).BeginInit();
            this.groupChonThongTinNguoiDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).BeginInit();
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
            this.groupChonThongTinNguoiDat.Controls.Add(this.lblHoatDong);
            this.groupChonThongTinNguoiDat.Controls.Add(this.txtTenNhanVien);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl2);
            this.groupChonThongTinNguoiDat.Controls.Add(this.txtMSNV);
            this.groupChonThongTinNguoiDat.Controls.Add(this.txtTenDangNhap);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl1);
            this.groupChonThongTinNguoiDat.Controls.Add(this.lblKiemTra);
            this.groupChonThongTinNguoiDat.Controls.Add(this.btnKiemTra);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl6);
            this.groupChonThongTinNguoiDat.Location = new System.Drawing.Point(64, 30);
            this.groupChonThongTinNguoiDat.Name = "groupChonThongTinNguoiDat";
            this.groupChonThongTinNguoiDat.Size = new System.Drawing.Size(541, 289);
            this.groupChonThongTinNguoiDat.TabIndex = 35;
            this.groupChonThongTinNguoiDat.Text = "Kiểm tra thông tin";
            // 
            // lblHoatDong
            // 
            this.lblHoatDong.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHoatDong.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lblHoatDong.Appearance.Options.UseFont = true;
            this.lblHoatDong.Appearance.Options.UseForeColor = true;
            this.lblHoatDong.Location = new System.Drawing.Point(38, 251);
            this.lblHoatDong.Name = "lblHoatDong";
            this.lblHoatDong.Size = new System.Drawing.Size(113, 17);
            this.lblHoatDong.TabIndex = 37;
            this.lblHoatDong.Text = "Đang hoạt động";
            this.lblHoatDong.Visible = false;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.EditValue = "";
            this.txtTenNhanVien.Enabled = false;
            this.txtTenNhanVien.Location = new System.Drawing.Point(202, 207);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txtTenNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtTenNhanVien.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.txtTenNhanVien.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txtTenNhanVien.Properties.Appearance.Options.UseForeColor = true;
            this.txtTenNhanVien.Properties.MaxLength = 50;
            this.txtTenNhanVien.Size = new System.Drawing.Size(284, 22);
            this.txtTenNhanVien.TabIndex = 34;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(38, 210);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 16);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "Tên nhân viên";
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
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.EditValue = "";
            this.txtTenDangNhap.Enabled = false;
            this.txtTenDangNhap.Location = new System.Drawing.Point(202, 166);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txtTenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtTenDangNhap.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.txtTenDangNhap.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.txtTenDangNhap.Properties.Appearance.Options.UseForeColor = true;
            this.txtTenDangNhap.Properties.MaxLength = 50;
            this.txtTenDangNhap.Size = new System.Drawing.Size(284, 22);
            this.txtTenDangNhap.TabIndex = 29;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(38, 169);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 17);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Tên tài khoản";
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
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(352, 337);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 29);
            this.btnHuy.TabIndex = 37;
            this.btnHuy.Text = "Huỷ";
            // 
            // btnKichHoat
            // 
            this.btnKichHoat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnKichHoat.Enabled = false;
            this.btnKichHoat.Location = new System.Drawing.Point(207, 337);
            this.btnKichHoat.Name = "btnKichHoat";
            this.btnKichHoat.Size = new System.Drawing.Size(102, 29);
            this.btnKichHoat.TabIndex = 36;
            this.btnKichHoat.Text = "Khoá tài khoản";
            // 
            // frmKhoaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 397);
            this.Controls.Add(this.groupChonThongTinNguoiDat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnKichHoat);
            this.IconOptions.Image = global::DXQLSB.Properties.Resources.ID_not_Verified_48px;
            this.Name = "frmKhoaTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHOÁ TÀI KHOẢN";
            ((System.ComponentModel.ISupportInitialize)(this.groupChonThongTinNguoiDat)).EndInit();
            this.groupChonThongTinNguoiDat.ResumeLayout(false);
            this.groupChonThongTinNguoiDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupChonThongTinNguoiDat;
        public DevExpress.XtraEditors.LabelControl lblHoatDong;
        public DevExpress.XtraEditors.TextEdit txtTenNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit txtMSNV;
        public DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.LabelControl lblKiemTra;
        public DevExpress.XtraEditors.SimpleButton btnKiemTra;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        public DevExpress.XtraEditors.SimpleButton btnKichHoat;
    }
}