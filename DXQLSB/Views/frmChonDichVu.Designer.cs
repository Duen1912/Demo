namespace DXQLSB.Views
{
    partial class frmChonDichVu
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
            this.btnDatNgay = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTrangThaiSan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblLoaiSan = new DevExpress.XtraEditors.LabelControl();
            this.groupChonThongTinNguoiDat = new DevExpress.XtraEditors.GroupControl();
            this.cbbDonGia = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbLoaiSan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbMaSan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtThanhTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cbbSanPham = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbSanDaDat = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThaiSan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChonThongTinNguoiDat)).BeginInit();
            this.groupChonThongTinNguoiDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiSan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaSan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSanDaDat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDatNgay
            // 
            this.btnDatNgay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDatNgay.Location = new System.Drawing.Point(189, 459);
            this.btnDatNgay.Name = "btnDatNgay";
            this.btnDatNgay.Size = new System.Drawing.Size(94, 29);
            this.btnDatNgay.TabIndex = 15;
            this.btnDatNgay.Text = "Đặt ngay";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(51, 50);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(58, 17);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Chọn sân";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(51, 302);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 17);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Số lượng";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(51, 220);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 17);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Chọn sản phẩm";
            // 
            // txtTrangThaiSan
            // 
            this.txtTrangThaiSan.EditValue = "Đã đặt";
            this.txtTrangThaiSan.Enabled = false;
            this.txtTrangThaiSan.Location = new System.Drawing.Point(220, 172);
            this.txtTrangThaiSan.Name = "txtTrangThaiSan";
            this.txtTrangThaiSan.Size = new System.Drawing.Size(246, 22);
            this.txtTrangThaiSan.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(51, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 16);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Mã sân";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 175);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 17);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Trạng thái sân";
            // 
            // lblLoaiSan
            // 
            this.lblLoaiSan.Location = new System.Drawing.Point(51, 133);
            this.lblLoaiSan.Name = "lblLoaiSan";
            this.lblLoaiSan.Size = new System.Drawing.Size(49, 17);
            this.lblLoaiSan.TabIndex = 4;
            this.lblLoaiSan.Text = "Loại sân";
            // 
            // groupChonThongTinNguoiDat
            // 
            this.groupChonThongTinNguoiDat.Controls.Add(this.cbbDonGia);
            this.groupChonThongTinNguoiDat.Controls.Add(this.cbbLoaiSan);
            this.groupChonThongTinNguoiDat.Controls.Add(this.cbbMaSan);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl5);
            this.groupChonThongTinNguoiDat.Controls.Add(this.txtSoLuong);
            this.groupChonThongTinNguoiDat.Controls.Add(this.txtThanhTien);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl7);
            this.groupChonThongTinNguoiDat.Controls.Add(this.cbbSanPham);
            this.groupChonThongTinNguoiDat.Controls.Add(this.cbbSanDaDat);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl6);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl3);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl4);
            this.groupChonThongTinNguoiDat.Controls.Add(this.txtTrangThaiSan);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl2);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl1);
            this.groupChonThongTinNguoiDat.Controls.Add(this.lblLoaiSan);
            this.groupChonThongTinNguoiDat.Location = new System.Drawing.Point(66, 35);
            this.groupChonThongTinNguoiDat.Name = "groupChonThongTinNguoiDat";
            this.groupChonThongTinNguoiDat.Size = new System.Drawing.Size(541, 404);
            this.groupChonThongTinNguoiDat.TabIndex = 14;
            this.groupChonThongTinNguoiDat.Text = "Đặt dịch vụ";
            // 
            // cbbDonGia
            // 
            this.cbbDonGia.EditValue = "0";
            this.cbbDonGia.Enabled = false;
            this.cbbDonGia.Location = new System.Drawing.Point(220, 255);
            this.cbbDonGia.Name = "cbbDonGia";
            this.cbbDonGia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cbbDonGia.Properties.Appearance.Options.UseFont = true;
            this.cbbDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbDonGia.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbDonGia.Size = new System.Drawing.Size(246, 22);
            this.cbbDonGia.TabIndex = 37;
            this.cbbDonGia.ToolTip = "Chọn sản phẩm";
            this.cbbDonGia.TextChanged += new System.EventHandler(this.txtSoLuong_ValueChanged);
            // 
            // cbbLoaiSan
            // 
            this.cbbLoaiSan.Enabled = false;
            this.cbbLoaiSan.Location = new System.Drawing.Point(220, 130);
            this.cbbLoaiSan.Name = "cbbLoaiSan";
            this.cbbLoaiSan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbLoaiSan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbLoaiSan.Size = new System.Drawing.Size(246, 22);
            this.cbbLoaiSan.TabIndex = 36;
            this.cbbLoaiSan.ToolTip = "Chọn dịch vụ cho sân";
            // 
            // cbbMaSan
            // 
            this.cbbMaSan.Enabled = false;
            this.cbbMaSan.Location = new System.Drawing.Point(220, 87);
            this.cbbMaSan.Name = "cbbMaSan";
            this.cbbMaSan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaSan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbMaSan.Size = new System.Drawing.Size(246, 22);
            this.cbbMaSan.TabIndex = 35;
            this.cbbMaSan.ToolTip = "Chọn dịch vụ cho sân";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(51, 261);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 16);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "Đơn giá";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtSoLuong.Location = new System.Drawing.Point(220, 302);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(246, 23);
            this.txtSoLuong.TabIndex = 32;
            this.txtSoLuong.ValueChanged += new System.EventHandler(this.txtSoLuong_ValueChanged);
            this.txtSoLuong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSoLuong_MouseClick);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.No;
            this.txtThanhTien.EditValue = "0";
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(220, 338);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.txtThanhTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtThanhTien.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.txtThanhTien.Properties.Appearance.Options.UseBackColor = true;
            this.txtThanhTien.Properties.Appearance.Options.UseFont = true;
            this.txtThanhTien.Properties.Appearance.Options.UseForeColor = true;
            this.txtThanhTien.Size = new System.Drawing.Size(246, 22);
            this.txtThanhTien.TabIndex = 31;
            this.txtThanhTien.ToolTip = "Tổng số tiền dịch vụ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(51, 341);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(122, 17);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "Thành tiền (VNĐ)";
            // 
            // cbbSanPham
            // 
            this.cbbSanPham.Location = new System.Drawing.Point(220, 215);
            this.cbbSanPham.Name = "cbbSanPham";
            this.cbbSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbSanPham.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbSanPham.Size = new System.Drawing.Size(246, 22);
            this.cbbSanPham.TabIndex = 2;
            this.cbbSanPham.ToolTip = "Chọn sản phẩm";
            this.cbbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbbSanPham_SelectedIndexChanged);
            // 
            // cbbSanDaDat
            // 
            this.cbbSanDaDat.EditValue = "";
            this.cbbSanDaDat.Location = new System.Drawing.Point(220, 47);
            this.cbbSanDaDat.Name = "cbbSanDaDat";
            this.cbbSanDaDat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbSanDaDat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbSanDaDat.Size = new System.Drawing.Size(246, 22);
            this.cbbSanDaDat.TabIndex = 1;
            this.cbbSanDaDat.ToolTip = "Chọn dịch vụ cho sân";
            this.cbbSanDaDat.SelectedIndexChanged += new System.EventHandler(this.cbbSanDaDat_SelectedIndexChanged);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuyBo.Location = new System.Drawing.Point(398, 459);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(94, 29);
            this.btnHuyBo.TabIndex = 16;
            this.btnHuyBo.Text = "Huỷ";
            // 
            // frmChonDichVu
            // 
            this.AcceptButton = this.btnDatNgay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 514);
            this.Controls.Add(this.btnDatNgay);
            this.Controls.Add(this.groupChonThongTinNguoiDat);
            this.Controls.Add(this.btnHuyBo);
            this.IconOptions.Image = global::DXQLSB.Properties.Resources.Food_And_Wine_96px;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChonDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN DỊCH VỤ";
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThaiSan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChonThongTinNguoiDat)).EndInit();
            this.groupChonThongTinNguoiDat.ResumeLayout(false);
            this.groupChonThongTinNguoiDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiSan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaSan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSanDaDat.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.TextEdit txtTrangThaiSan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblLoaiSan;
        private DevExpress.XtraEditors.GroupControl groupChonThongTinNguoiDat;
        private DevExpress.XtraEditors.SimpleButton btnHuyBo;
        public DevExpress.XtraEditors.TextEdit txtThanhTien;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.ComboBoxEdit cbbSanDaDat;
        public DevExpress.XtraEditors.ComboBoxEdit cbbSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.ComboBoxEdit cbbLoaiSan;
        public DevExpress.XtraEditors.ComboBoxEdit cbbMaSan;
        public DevExpress.XtraEditors.SimpleButton btnDatNgay;
        public DevExpress.XtraEditors.ComboBoxEdit cbbDonGia;
        public System.Windows.Forms.NumericUpDown txtSoLuong;
    }
}