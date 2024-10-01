namespace DXQLSB.Views
{
    partial class frmThemDichVu
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
            this.groupChonThongTinNguoiDat = new DevExpress.XtraEditors.GroupControl();
            this.txtDonGiaSanPham = new DevExpress.XtraEditors.TextEdit();
            this.cbbMaDichVu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbbTenLoaiDichVu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemNgay = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupChonThongTinNguoiDat)).BeginInit();
            this.groupChonThongTinNguoiDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaDichVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTenLoaiDichVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupChonThongTinNguoiDat
            // 
            this.groupChonThongTinNguoiDat.Controls.Add(this.txtDonGiaSanPham);
            this.groupChonThongTinNguoiDat.Controls.Add(this.cbbMaDichVu);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl5);
            this.groupChonThongTinNguoiDat.Controls.Add(this.cbbTenLoaiDichVu);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl6);
            this.groupChonThongTinNguoiDat.Controls.Add(this.txtTenSanPham);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl2);
            this.groupChonThongTinNguoiDat.Controls.Add(this.labelControl1);
            this.groupChonThongTinNguoiDat.Location = new System.Drawing.Point(32, 12);
            this.groupChonThongTinNguoiDat.Name = "groupChonThongTinNguoiDat";
            this.groupChonThongTinNguoiDat.Size = new System.Drawing.Size(541, 233);
            this.groupChonThongTinNguoiDat.TabIndex = 17;
            this.groupChonThongTinNguoiDat.Text = "Thông tin chi tiết";
            // 
            // txtDonGiaSanPham
            // 
            this.txtDonGiaSanPham.EditValue = "";
            this.txtDonGiaSanPham.Location = new System.Drawing.Point(220, 175);
            this.txtDonGiaSanPham.Name = "txtDonGiaSanPham";
            this.txtDonGiaSanPham.Properties.MaxLength = 10;
            this.txtDonGiaSanPham.Size = new System.Drawing.Size(246, 22);
            this.txtDonGiaSanPham.TabIndex = 36;
            this.txtDonGiaSanPham.EditValueChanged += new System.EventHandler(this.txtDonGiaSanPham_EditValueChanged);
            this.txtDonGiaSanPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaSanPham_KeyPress);
            this.txtDonGiaSanPham.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtDonGiaSanPham_PreviewKeyDown);
            // 
            // cbbMaDichVu
            // 
            this.cbbMaDichVu.Enabled = false;
            this.cbbMaDichVu.Location = new System.Drawing.Point(220, 87);
            this.cbbMaDichVu.Name = "cbbMaDichVu";
            this.cbbMaDichVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaDichVu.Properties.ReadOnly = true;
            this.cbbMaDichVu.Size = new System.Drawing.Size(246, 22);
            this.cbbMaDichVu.TabIndex = 35;
            this.cbbMaDichVu.ToolTip = "Chọn dịch vụ cho sân";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(51, 178);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 16);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "Đơn giá";
            // 
            // cbbTenLoaiDichVu
            // 
            this.cbbTenLoaiDichVu.EditValue = "";
            this.cbbTenLoaiDichVu.Location = new System.Drawing.Point(220, 47);
            this.cbbTenLoaiDichVu.Name = "cbbTenLoaiDichVu";
            this.cbbTenLoaiDichVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbTenLoaiDichVu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbTenLoaiDichVu.Size = new System.Drawing.Size(246, 22);
            this.cbbTenLoaiDichVu.TabIndex = 1;
            this.cbbTenLoaiDichVu.ToolTip = "Chọn dịch vụ cho sân";
            this.cbbTenLoaiDichVu.SelectedIndexChanged += new System.EventHandler(this.cbbTenLoaiDichVu_SelectedIndexChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(51, 50);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(105, 17);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Chọn loại dịch vụ";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.EditValue = "";
            this.txtTenSanPham.Location = new System.Drawing.Point(220, 129);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Properties.MaxLength = 50;
            this.txtTenSanPham.Size = new System.Drawing.Size(246, 22);
            this.txtTenSanPham.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(51, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 17);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Mã dịch vụ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 132);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 17);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Tên sản phẩm:";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuyBo.Location = new System.Drawing.Point(369, 274);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(94, 29);
            this.btnHuyBo.TabIndex = 19;
            this.btnHuyBo.Text = "Huỷ";
            // 
            // btnThemNgay
            // 
            this.btnThemNgay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnThemNgay.Location = new System.Drawing.Point(160, 274);
            this.btnThemNgay.Name = "btnThemNgay";
            this.btnThemNgay.Size = new System.Drawing.Size(94, 29);
            this.btnThemNgay.TabIndex = 18;
            this.btnThemNgay.Text = "Thêm ngay";
            // 
            // frmThemDichVu
            // 
            this.AcceptButton = this.btnThemNgay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 328);
            this.Controls.Add(this.groupChonThongTinNguoiDat);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnThemNgay);
            this.IconOptions.Image = global::DXQLSB.Properties.Resources.Plus_48px;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM DỊCH VỤ";
            this.Load += new System.EventHandler(this.frmThemDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupChonThongTinNguoiDat)).EndInit();
            this.groupChonThongTinNguoiDat.ResumeLayout(false);
            this.groupChonThongTinNguoiDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaDichVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTenLoaiDichVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupChonThongTinNguoiDat;
        public DevExpress.XtraEditors.TextEdit txtDonGiaSanPham;
        public DevExpress.XtraEditors.ComboBoxEdit cbbMaDichVu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.ComboBoxEdit cbbTenLoaiDichVu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.TextEdit txtTenSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuyBo;
        public DevExpress.XtraEditors.SimpleButton btnThemNgay;
    }
}