namespace DXQLSB.Views
{
    partial class frmAbout
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
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.groupCtrlThongTinNguoiDung = new DevExpress.XtraEditors.GroupControl();
            this.cbbGioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.lblTenDangNhap = new DevExpress.XtraEditors.LabelControl();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.txtNgayTao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMSNV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrlThongTinNguoiDung)).BeginInit();
            this.groupCtrlThongTinNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnHuy.Location = new System.Drawing.Point(350, 416);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 29);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Huỷ";
            // 
            // groupCtrlThongTinNguoiDung
            // 
            this.groupCtrlThongTinNguoiDung.Controls.Add(this.cbbGioiTinh);
            this.groupCtrlThongTinNguoiDung.Controls.Add(this.txtTenDangNhap);
            this.groupCtrlThongTinNguoiDung.Controls.Add(this.lblTenDangNhap);
            this.groupCtrlThongTinNguoiDung.Controls.Add(this.btnSua);
            this.groupCtrlThongTinNguoiDung.Controls.Add(this.txtNgayTao);
            this.groupCtrlThongTinNguoiDung.Controls.Add(this.labelControl3);
            this.groupCtrlThongTinNguoiDung.Controls.Add(this.txtDiaChi);
            this.groupCtrlThongTinNguoiDung.Controls.Add(this.labelControl4);
            this.groupCtrlThongTinNguoiDung.Controls.Add(this.labelControl5);
            this.groupCtrlThongTinNguoiDung.Controls.Add(this.txtHoTen);
            this.groupCtrlThongTinNguoiDung.Controls.Add(this.labelControl2);
            this.groupCtrlThongTinNguoiDung.Controls.Add(this.txtMSNV);
            this.groupCtrlThongTinNguoiDung.Controls.Add(this.labelControl1);
            this.groupCtrlThongTinNguoiDung.Location = new System.Drawing.Point(34, 12);
            this.groupCtrlThongTinNguoiDung.Name = "groupCtrlThongTinNguoiDung";
            this.groupCtrlThongTinNguoiDung.Size = new System.Drawing.Size(457, 381);
            this.groupCtrlThongTinNguoiDung.TabIndex = 5;
            this.groupCtrlThongTinNguoiDung.Text = "Thông tin người dùng";
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.EditValue = "Nam";
            this.cbbGioiTinh.Enabled = false;
            this.cbbGioiTinh.Location = new System.Drawing.Point(164, 194);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbGioiTinh.Properties.DropDownRows = 2;
            this.cbbGioiTinh.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbGioiTinh.Size = new System.Drawing.Size(246, 22);
            this.cbbGioiTinh.TabIndex = 15;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.EditValue = "Chưa có dữ liệu";
            this.txtTenDangNhap.Enabled = false;
            this.txtTenDangNhap.Location = new System.Drawing.Point(164, 113);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTenDangNhap.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(246, 22);
            this.txtTenDangNhap.TabIndex = 14;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Location = new System.Drawing.Point(39, 116);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(93, 17);
            this.lblTenDangNhap.TabIndex = 13;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(164, 317);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(57, 29);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.EditValue = "Chưa có dữ liệu";
            this.txtNgayTao.Enabled = false;
            this.txtNgayTao.Location = new System.Drawing.Point(164, 272);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNgayTao.Properties.Appearance.Options.UseBackColor = true;
            this.txtNgayTao.Size = new System.Drawing.Size(246, 22);
            this.txtNgayTao.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(39, 275);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 17);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Ngày tạo";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.EditValue = "Chưa có dữ liệu";
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(164, 233);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(246, 22);
            this.txtDiaChi.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(39, 236);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 17);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Địa chỉ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(39, 197);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 17);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Giới tính";
            // 
            // txtHoTen
            // 
            this.txtHoTen.EditValue = "Chưa có dữ liệu";
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(164, 154);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(246, 22);
            this.txtHoTen.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(39, 157);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Họ tên";
            // 
            // txtMSNV
            // 
            this.txtMSNV.EditValue = "Chưa có dữ liệu";
            this.txtMSNV.Enabled = false;
            this.txtMSNV.Location = new System.Drawing.Point(164, 75);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMSNV.Properties.Appearance.Options.UseBackColor = true;
            this.txtMSNV.Size = new System.Drawing.Size(246, 22);
            this.txtMSNV.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "MSNV";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(105, 416);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 29);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 470);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupCtrlThongTinNguoiDung);
            this.IconOptions.Image = global::DXQLSB.Properties.Resources.More_Info_96px;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÀI KHOẢN";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrlThongTinNguoiDung)).EndInit();
            this.groupCtrlThongTinNguoiDung.ResumeLayout(false);
            this.groupCtrlThongTinNguoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSNV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.GroupControl groupCtrlThongTinNguoiDung;
        public DevExpress.XtraEditors.TextEdit txtMSNV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit txtNgayTao;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        public DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraEditors.LabelControl lblTenDangNhap;
        private DevExpress.XtraEditors.ComboBoxEdit cbbGioiTinh;
    }
}