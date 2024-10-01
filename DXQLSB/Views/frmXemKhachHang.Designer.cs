namespace DXQLSB.Views
{
    partial class frmXemKhachHang
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
            this.components = new System.ComponentModel.Container();
            this.groupChonThongTinNguoiDat = new DevExpress.XtraEditors.GroupControl();
            this.gridTTKH = new DevExpress.XtraGrid.GridControl();
            this.thongtinkhachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongtinkhachhangDS = new DXQLSB.thongtinkhachhangDS();
            this.gridViewThongTinKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcmnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.thongtinkhachhangTableAdapter = new DXQLSB.thongtinkhachhangDSTableAdapters.thongtinkhachhangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupChonThongTinNguoiDat)).BeginInit();
            this.groupChonThongTinNguoiDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTTKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinkhachhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinkhachhangDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThongTinKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupChonThongTinNguoiDat
            // 
            this.groupChonThongTinNguoiDat.Controls.Add(this.gridTTKH);
            this.groupChonThongTinNguoiDat.Location = new System.Drawing.Point(41, 23);
            this.groupChonThongTinNguoiDat.Name = "groupChonThongTinNguoiDat";
            this.groupChonThongTinNguoiDat.Size = new System.Drawing.Size(857, 404);
            this.groupChonThongTinNguoiDat.TabIndex = 17;
            this.groupChonThongTinNguoiDat.Text = "Chi tiết";
            // 
            // gridTTKH
            // 
            this.gridTTKH.DataSource = this.thongtinkhachhangBindingSource;
            this.gridTTKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTTKH.EmbeddedNavigator.Buttons.Append.Hint = "Thêm";
            this.gridTTKH.EmbeddedNavigator.Buttons.CancelEdit.Hint = "Huỷ sửa";
            this.gridTTKH.EmbeddedNavigator.Buttons.Edit.Hint = "Sửa";
            this.gridTTKH.EmbeddedNavigator.Buttons.EndEdit.Hint = "Lưu";
            this.gridTTKH.EmbeddedNavigator.Buttons.Remove.Hint = "Xoá";
            this.gridTTKH.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridTTKH_EmbeddedNavigator_ButtonClick);
            this.gridTTKH.Location = new System.Drawing.Point(2, 28);
            this.gridTTKH.MainView = this.gridViewThongTinKhachHang;
            this.gridTTKH.Name = "gridTTKH";
            this.gridTTKH.Size = new System.Drawing.Size(853, 374);
            this.gridTTKH.TabIndex = 0;
            this.gridTTKH.UseEmbeddedNavigator = true;
            this.gridTTKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewThongTinKhachHang});
            // 
            // thongtinkhachhangBindingSource
            // 
            this.thongtinkhachhangBindingSource.DataMember = "thongtinkhachhang";
            this.thongtinkhachhangBindingSource.DataSource = this.thongtinkhachhangDS;
            // 
            // thongtinkhachhangDS
            // 
            this.thongtinkhachhangDS.DataSetName = "thongtinkhachhangDS";
            this.thongtinkhachhangDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewThongTinKhachHang
            // 
            this.gridViewThongTinKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colhoten,
            this.colcmnd,
            this.colsdt,
            this.coldiachi});
            this.gridViewThongTinKhachHang.GridControl = this.gridTTKH;
            this.gridViewThongTinKhachHang.Name = "gridViewThongTinKhachHang";
            this.gridViewThongTinKhachHang.OptionsFind.AlwaysVisible = true;
            this.gridViewThongTinKhachHang.OptionsFind.FindNullPrompt = "Nhập để tìm kiếm ...";
            this.gridViewThongTinKhachHang.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewThongTinKhachHang.OptionsView.ShowFooter = true;
            this.gridViewThongTinKhachHang.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.AppearanceCell.Options.UseTextOptions = true;
            this.colid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid.AppearanceHeader.Options.UseTextOptions = true;
            this.colid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid.FieldName = "id";
            this.colid.MinWidth = 25;
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 36;
            // 
            // colhoten
            // 
            this.colhoten.AppearanceCell.Options.UseTextOptions = true;
            this.colhoten.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhoten.AppearanceHeader.Options.UseTextOptions = true;
            this.colhoten.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhoten.Caption = "Họ tên";
            this.colhoten.FieldName = "hoten";
            this.colhoten.MinWidth = 25;
            this.colhoten.Name = "colhoten";
            this.colhoten.Visible = true;
            this.colhoten.VisibleIndex = 1;
            this.colhoten.Width = 117;
            // 
            // colcmnd
            // 
            this.colcmnd.AppearanceCell.Options.UseTextOptions = true;
            this.colcmnd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcmnd.AppearanceHeader.Options.UseTextOptions = true;
            this.colcmnd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcmnd.Caption = "CMND";
            this.colcmnd.FieldName = "cmnd";
            this.colcmnd.MinWidth = 25;
            this.colcmnd.Name = "colcmnd";
            this.colcmnd.Visible = true;
            this.colcmnd.VisibleIndex = 2;
            this.colcmnd.Width = 117;
            // 
            // colsdt
            // 
            this.colsdt.AppearanceCell.Options.UseTextOptions = true;
            this.colsdt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsdt.AppearanceHeader.Options.UseTextOptions = true;
            this.colsdt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsdt.Caption = "SĐT";
            this.colsdt.FieldName = "sdt";
            this.colsdt.MinWidth = 25;
            this.colsdt.Name = "colsdt";
            this.colsdt.Visible = true;
            this.colsdt.VisibleIndex = 3;
            this.colsdt.Width = 117;
            // 
            // coldiachi
            // 
            this.coldiachi.AppearanceCell.Options.UseTextOptions = true;
            this.coldiachi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldiachi.AppearanceHeader.Options.UseTextOptions = true;
            this.coldiachi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldiachi.Caption = "Địa chỉ";
            this.coldiachi.FieldName = "diachi";
            this.coldiachi.MinWidth = 25;
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.Visible = true;
            this.coldiachi.VisibleIndex = 4;
            this.coldiachi.Width = 122;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(407, 453);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 29);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "OK";
            // 
            // thongtinkhachhangTableAdapter
            // 
            this.thongtinkhachhangTableAdapter.ClearBeforeFill = true;
            // 
            // frmXemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 494);
            this.Controls.Add(this.groupChonThongTinNguoiDat);
            this.Controls.Add(this.btnOK);
            this.IconOptions.Image = global::DXQLSB.Properties.Resources.Client_Management_48px;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXemKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmXemKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupChonThongTinNguoiDat)).EndInit();
            this.groupChonThongTinNguoiDat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTTKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinkhachhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinkhachhangDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThongTinKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupChonThongTinNguoiDat;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private thongtinkhachhangDS thongtinkhachhangDS;
        private System.Windows.Forms.BindingSource thongtinkhachhangBindingSource;
        private thongtinkhachhangDSTableAdapters.thongtinkhachhangTableAdapter thongtinkhachhangTableAdapter;
        private DevExpress.XtraGrid.GridControl gridTTKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewThongTinKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colhoten;
        private DevExpress.XtraGrid.Columns.GridColumn colcmnd;
        private DevExpress.XtraGrid.Columns.GridColumn colsdt;
        private DevExpress.XtraGrid.Columns.GridColumn coldiachi;
    }
}