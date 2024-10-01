namespace DXQLSB.Views
{
    partial class frmChonLoaiSan
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
            this.groupChonThongTinSan = new DevExpress.XtraEditors.GroupControl();
            this.cbbTrangThaiSan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbDonGia = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbbLoaiSan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblDonGia = new DevExpress.XtraEditors.LabelControl();
            this.lblLoaiSan = new DevExpress.XtraEditors.LabelControl();
            this.btnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupChonThongTinSan)).BeginInit();
            this.groupChonThongTinSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTrangThaiSan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiSan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupChonThongTinSan
            // 
            this.groupChonThongTinSan.Controls.Add(this.cbbTrangThaiSan);
            this.groupChonThongTinSan.Controls.Add(this.cbbDonGia);
            this.groupChonThongTinSan.Controls.Add(this.labelControl1);
            this.groupChonThongTinSan.Controls.Add(this.cbbLoaiSan);
            this.groupChonThongTinSan.Controls.Add(this.lblDonGia);
            this.groupChonThongTinSan.Controls.Add(this.lblLoaiSan);
            this.groupChonThongTinSan.Location = new System.Drawing.Point(31, 30);
            this.groupChonThongTinSan.Name = "groupChonThongTinSan";
            this.groupChonThongTinSan.Size = new System.Drawing.Size(541, 187);
            this.groupChonThongTinSan.TabIndex = 8;
            this.groupChonThongTinSan.Text = "Thông tin sân";
            // 
            // cbbTrangThaiSan
            // 
            this.cbbTrangThaiSan.EditValue = "Đang trống";
            this.cbbTrangThaiSan.Location = new System.Drawing.Point(220, 138);
            this.cbbTrangThaiSan.Name = "cbbTrangThaiSan";
            this.cbbTrangThaiSan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbTrangThaiSan.Properties.DropDownRows = 2;
            this.cbbTrangThaiSan.Properties.Items.AddRange(new object[] {
            "All",
            "Đang trống"});
            this.cbbTrangThaiSan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbTrangThaiSan.Size = new System.Drawing.Size(246, 22);
            this.cbbTrangThaiSan.TabIndex = 12;
            // 
            // cbbDonGia
            // 
            this.cbbDonGia.EditValue = "All";
            this.cbbDonGia.Location = new System.Drawing.Point(220, 98);
            this.cbbDonGia.Name = "cbbDonGia";
            this.cbbDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbDonGia.Properties.DropDownRows = 5;
            this.cbbDonGia.Properties.Items.AddRange(new object[] {
            "All"});
            this.cbbDonGia.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbDonGia.Size = new System.Drawing.Size(246, 22);
            this.cbbDonGia.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 141);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 17);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Trạng thái sân";
            // 
            // cbbLoaiSan
            // 
            this.cbbLoaiSan.EditValue = "All";
            this.cbbLoaiSan.Location = new System.Drawing.Point(220, 61);
            this.cbbLoaiSan.Name = "cbbLoaiSan";
            this.cbbLoaiSan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbLoaiSan.Properties.DropDownRows = 5;
            this.cbbLoaiSan.Properties.Items.AddRange(new object[] {
            "All"});
            this.cbbLoaiSan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbLoaiSan.Size = new System.Drawing.Size(246, 22);
            this.cbbLoaiSan.TabIndex = 9;
            // 
            // lblDonGia
            // 
            this.lblDonGia.Location = new System.Drawing.Point(51, 101);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(42, 16);
            this.lblDonGia.TabIndex = 6;
            this.lblDonGia.Text = "Giá sân";
            // 
            // lblLoaiSan
            // 
            this.lblLoaiSan.Location = new System.Drawing.Point(51, 61);
            this.lblLoaiSan.Name = "lblLoaiSan";
            this.lblLoaiSan.Size = new System.Drawing.Size(49, 17);
            this.lblLoaiSan.TabIndex = 4;
            this.lblLoaiSan.Text = "Loại sân";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuyBo.Location = new System.Drawing.Point(366, 240);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(94, 29);
            this.btnHuyBo.TabIndex = 10;
            this.btnHuyBo.Text = "Cancel";
            // 
            // btnDongY
            // 
            this.btnDongY.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDongY.Location = new System.Drawing.Point(157, 240);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(94, 29);
            this.btnDongY.TabIndex = 9;
            this.btnDongY.Text = "OK";
            // 
            // frmChonLoaiSan
            // 
            this.AcceptButton = this.btnDongY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 301);
            this.Controls.Add(this.groupChonThongTinSan);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnDongY);
            this.IconOptions.Image = global::DXQLSB.Properties.Resources.Stadium_96px;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChonLoaiSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỌN LOẠI SÂN";
            this.Load += new System.EventHandler(this.frmChonLoaiSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupChonThongTinSan)).EndInit();
            this.groupChonThongTinSan.ResumeLayout(false);
            this.groupChonThongTinSan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTrangThaiSan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiSan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupChonThongTinSan;
        private DevExpress.XtraEditors.LabelControl lblDonGia;
        private DevExpress.XtraEditors.LabelControl lblLoaiSan;
        private DevExpress.XtraEditors.SimpleButton btnHuyBo;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.ComboBoxEdit cbbDonGia;
        public DevExpress.XtraEditors.ComboBoxEdit cbbLoaiSan;
        public DevExpress.XtraEditors.ComboBoxEdit cbbTrangThaiSan;
    }
}